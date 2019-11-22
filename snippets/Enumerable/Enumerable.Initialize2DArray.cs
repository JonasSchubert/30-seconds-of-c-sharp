using System;

namespace JonasSchubert.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Initializes a 2D array of given width and height and value.
        /// </summary>
        public static T[,] Initialize2DArray<T>(uint width, uint height, T defaultValue = default(T))
        {
            if (width == 0)
            {
                throw new ArgumentException($"Minimum {nameof(width)} has to be 1", nameof(width));
            }

            if (height == 0)
            {
                throw new ArgumentException($"Minimum {nameof(height)} has to be 1", nameof(height));
            }

            var newArray = new T[width, height];

            for (int widthIndex = 0; widthIndex < width; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < height; heightIndex++)
                {
                    newArray[widthIndex, heightIndex] = defaultValue;
                }
            }

            return newArray;
        }
    }
}
