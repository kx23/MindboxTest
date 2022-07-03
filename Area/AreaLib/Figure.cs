namespace AreaLib
{
    public abstract class Figure
    {
        
        public float Area { get; protected set; }
        protected abstract float CalculateArea();
    }
}
