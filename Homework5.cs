using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Homework5__array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The address of the image data file import. : ");
            string ImportFile = Console.ReadLine();
            double[,] ImportFileArray = ReadImageDataFromFile(ImportFile);
            ReadImageDataFromFile(ImportFile);

            Console.Write("The address of the file Convolution Kernel : ");
            string ConvolutionFile = Console.ReadLine();   
            double[,] ConvolutionArray = ReadImageDataFromFile(ConvolutionFile);
            ReadImageDataFromFile(ConvolutionFile);

            Console.Write("The address of the output image data file : ");
            string OutputData = Console.ReadLine();


            int AddColumnArray = ImportFileArray.GetLength(0) + ConvolutionArray.GetLength(0) - 1;
            int AddRowArray = ImportFileArray.GetLength(1) + ConvolutionArray.GetLength(1) - 1;

            double[,] AddDataArray = ExpandedDataArray(ImportFileArray, AddColumnArray, AddRowArray, ImportFileArray.GetLength(0), ImportFileArray.GetLength(1));

            double[,] OutputImageData = ConvolutionOP(AddDataArray, ConvolutionArray, ImportFileArray.GetLength(0), ImportFileArray.GetLength(1));

            WriteImageDataToFile(OutputData, OutputImageData);
        }

        static double[,] ExpandedDataArray(double[,] ImportFileArray, int addColumn, int addRow, int columnArray, int rowArray)
        {
            double[,] AddImageArray = new double[addColumn, addRow];
            for (int i = 0; i < addColumn; i++)
            {
                for (int j = 0; j < addRow; j++)
                {
                    AddImageArray[i, j] = ImportFileArray[(i + (columnArray - 1)) % columnArray, (j + (rowArray - 1)) % rowArray];
                }
            }

            return AddImageArray;
        }

        static double[,] ConvolutionOP(double[,] expandedDataArray ,double[,] convolutionArray ,int dataArrayColumn, int dataArrayRow)
        {
            double[,] outputImageArray = new double[dataArrayColumn,dataArrayRow];

            for (int i = 0; i < dataArrayColumn; i++)
            {
                for (int j = 0; j < dataArrayRow; j++)
                {
                    for (int k = 0; k < convolutionArray.GetLength(0); k++)
                    {
                        for (int l = 0; l < convolutionArray.GetLength(1); l++)
                        {
                            outputImageArray[i, j] += expandedDataArray[i + k, j + l] * convolutionArray[k, l];
                        }
                    }
                }
            }
            return outputImageArray;
        }

        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static void WriteImageDataToFile(string imageDataFilePath,
                                 double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

    }
}
