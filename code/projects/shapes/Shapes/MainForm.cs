using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Shapes.Shapes;

namespace Shapes
{
    /// <summary>
    /// Main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            ProcessShapesData();
        }

        /// <summary>
        /// Processes shapes data.
        /// </summary>
        private void ProcessShapesData()
        {
            string dataFilePath = Environment.CurrentDirectory + Constants.ShapesDataFilePath;

            if (File.Exists(dataFilePath))
            {
                string[] csvData = File.ReadAllLines(dataFilePath);

                if (csvData == null || csvData.Length < 1)
                    MessageBox.Show("Invalid or no data found in file:" + Environment.NewLine + Environment.NewLine + dataFilePath, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBoxOutput.Text = null;

                    IList<Triangle> triangles = new List<Triangle>();
                    IList<Circle> circles = new List<Circle>();

                    foreach (string csvLine in csvData)
                    {
                        string[] lineData = csvLine.Split(Constants.CSVDataSep1);

                        if (lineData == null || lineData.Length < 1)
                            MessageBox.Show("Invalid or no data found in line:" + Environment.NewLine + Environment.NewLine + lineData, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            string shapePrefix = lineData[0].Trim();
                            if (shapePrefix == Constants.ShapesDataTriangleDataPrefix)
                            {
                                float point1X = 0f;
                                float point1Y = 0f;
                                float point2X = 0f;
                                float point2Y = 0f;
                                float point3X = 0f;
                                float point3Y = 0f;

                                if (float.TryParse(lineData[1], out point1X) && float.TryParse(lineData[2], out point1Y)
                                        && float.TryParse(lineData[3], out point2X) && float.TryParse(lineData[4], out point2Y)
                                        && float.TryParse(lineData[5], out point3X) && float.TryParse(lineData[6], out point3Y))
                                {
                                    Triangle tri = new Triangle { Point1X = point1X, Point1Y = point1Y, Point2X = point2X, Point2Y = point2Y, Point3X = point3X, Point3Y = point3Y };
                                    triangles.Add(tri);
                                }
                                else
                                    MessageBox.Show("Invalid or no data found in line:" + Environment.NewLine + Environment.NewLine + lineData, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (shapePrefix == Constants.ShapesDataCircleDataPrefix)
                            {
                                float point1X = 0f;
                                float point1Y = 0f;
                                float radius = 0f;
                                if (float.TryParse(lineData[1], out point1X) && float.TryParse(lineData[2], out point1Y)
                                        && float.TryParse(lineData[3], out radius))
                                {
                                    Circle cir = new Circle { Point1X = point1X, Point1Y = point1Y, Radius = radius };
                                    circles.Add(cir);
                                }
                            }
                            else
                                MessageBox.Show("Unknown shape prefix: " + shapePrefix, "Unknown Prefix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    textBoxOutput.Text = "Processed data file: " + dataFilePath + Environment.NewLine + Environment.NewLine;
                    textBoxOutput.Text += "Total shapes: " + (triangles.Count + circles.Count) + Environment.NewLine;
                    textBoxOutput.Text += "Total triangles: " + triangles.Count + Environment.NewLine;
                    textBoxOutput.Text += "Total circles: " + circles.Count + Environment.NewLine;

                    float maxTriArea = triangles.Max(t => t.Area);
                    float maxCirArea = circles.Max(c => c.Area);

                    textBoxOutput.Text += "Largest triangle area: " + maxTriArea.ToString("n") + Environment.NewLine;
                    textBoxOutput.Text += "Largest circle area: " + maxCirArea.ToString("n") + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Unable to locate data file at:" + Environment.NewLine + Environment.NewLine + dataFilePath, "Data File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}