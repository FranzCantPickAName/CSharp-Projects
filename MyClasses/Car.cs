namespace MyClasses
{
    public class Car
    {
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };

        /// <summary>
        /// The brand of the car
        /// </summary>
        /// <param name="index">Used to access the brand of the current object of this class</param>
        /// <returns>The name of the car brand (as a string)</returns>
        public string this[int index]
        {
            set
            {
                this._brands[index] = value;
            }
            get
            {
                return this._brands[index];
            }
        }

    }
}
