namespace ConsoleApp33
{
    public class tempF
    {
        private float _temp;
        public float tempValue
        {
            set{_temp=value;}
            get{return this._temp;}
        }

        public tempF()
        {}
        public tempF(float tempvalue):this()
        {
            this._temp=tempValue;
        }

        public override string ToString()
        {
            return this.tempValue.ToString();
        }
    }
}