using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AKWare.Audio;

namespace GuitarTuner
{
	public partial class Form1 : Form
	{
		Recorder recorder = null;
//		Player player = null;
		float[] spectrum = new float[256];
		float[] psd = new float[128];
		float[] block = new float[256];
		float[] hann = new float[256];
		MemoryStream ms = new MemoryStream(8192);
		Queue<short[]> bufferQueue = new Queue<short[]>();
		DateTime lastFrequencyUpdate = DateTime.Now;
		float lastDominantFrequency = 0.0f;

		public Form1()
		{
			InitializeComponent();

			for (int i = 0; i < 256; i++)
			{
				hann[i] = 0.5f * (float)(1.0 - Math.Cos(2.0 * Math.PI * i / 255));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			recorder = new AKWare.Audio.Recorder(0, 8000, 16, 1);
			recorder.BufferFull += new Recorder.BufferFullDelegate(recorder_BufferFull);
			recorder.Start();

//			player = new AKWare.Audio.Player(bufferQueue, 0, 8000, 16, 1);
		}

		void recorder_BufferFull(object sender, Recorder.BufferFullEventArgs e)
		{
			Fourier f = new Fourier();

			for (int k = 0; k < e.buffer.data.Length; k++)
			{
				block[k] = (float)e.buffer.data[k];
			}

			// simulate a signal - sawtooth
			/*			for (int i = 0; i < 256; i++)
						{
							float q = i * 1000.0f / 8000.0f;
							block[i] = (float)(2.0f * 1.0f * (q - Math.Round(q)));
						}
			*/
//						float theta = 2.0f * (float)Math.PI * 1000.0f / 8000.0f;
//						for (int i = 0; i < 256; i++)
//							block[i] = 1.0f * (float)Math.Sin(i * theta);
			

			float[] imgout = new float[256];
			float[] realout = new float[256];
			float[] imagout = new float[256];

			f.fft(256, false, block, null, spectrum, imgout);
			psd = f.fftMag(block);

			window(spectrum, spectrum, hann, 256);

			f.fft(256, true, spectrum, imgout, block, imagout);

			try
			{
				Invoke(new MethodInvoker(pictureBox1.Refresh));
			}
			catch
			{
			}
		}

		void window(float[] z, float[] x, float[] y, int n)
		{
			for (int i = 0; i < n; i++) z[i] = x[i] * y[i];
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			recorder.Stop();
			recorder.Close();
			recorder = null;
//			player.Stop();
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			PointF[] pts = new PointF[128];
			e.Graphics.FillRectangle(new SolidBrush(Color.White), e.ClipRectangle);
			float scale = e.ClipRectangle.Width / 128.0f;

			// find the peak power for the dominant frequency
			int maxi = 0;
			float max = 0.0f;
			for (int i = 0; i < 128; i++)
			{
				if (psd[i] > max)
				{
					max = psd[i];
					maxi = i;
				}
			}

			max = 7000.0f;
			for (int i = 0; i < 128; i++)
			{
				if (psd[i] > max)
				{
					max = psd[i];
				}
			}
			float scaley = e.ClipRectangle.Height / max;

			for (int i = 0; i < 128; i++)
			{
				pts[i].X = (float)i * scale;
				pts[i].Y = e.ClipRectangle.Height - (psd[i] * scaley);
			}

			e.Graphics.DrawLines(new Pen(Color.Red), pts);

			float scalef = e.ClipRectangle.Width / 4000.0f;
			for (float f = 0.0f; f <= 4000.0f; f += 250.0f)
			{
				e.Graphics.DrawLine(new Pen(Color.Black), new Point((int)(f * scalef), e.ClipRectangle.Bottom), new Point((int)(f * scalef), e.ClipRectangle.Bottom - 1));
			}

			float cutoff = 500.0f;
			e.Graphics.DrawLine(new Pen(Color.Blue), new Point(e.ClipRectangle.Left, e.ClipRectangle.Height - (int)(cutoff * scaley)), new Point(e.ClipRectangle.Right, e.ClipRectangle.Height - (int)(cutoff * scaley)));

			if ((DateTime.Now - lastFrequencyUpdate).Seconds >= 1)
			{
				lastDominantFrequency = maxi / scalef;
				lastFrequencyUpdate = DateTime.Now;
			}
			e.Graphics.DrawString("Dominant frequency: " + lastDominantFrequency.ToString("F3") + "Hz", new Font("Tahoma", 8.5f), new SolidBrush(Color.Black), new PointF(0.0f, 0.0f));

			float targetFrequency = 0.0f;
			if (radio6.Checked)
			{
				targetFrequency = 329.628f;
			}
			else if (radio5.Checked)
			{
				targetFrequency = 246.942f;
			}
			else if (radio4.Checked)
			{
				targetFrequency = 195.998f;
			}
			else if (radio3.Checked)
			{
				targetFrequency = 146.832f;
			}
			else if (radio2.Checked)
			{
				targetFrequency = 110.0f;
			}
			else if (radio1.Checked)
			{
				targetFrequency = 82.407f;
			}
			e.Graphics.DrawLine(new Pen(Color.Green), new PointF(targetFrequency * scalef, e.ClipRectangle.Bottom), new PointF(targetFrequency * scalef, e.ClipRectangle.Top));
		}

	}
}