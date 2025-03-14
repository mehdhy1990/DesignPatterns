namespace DesignPatternPractice.Builder;

public record Dough(string thickness, string color)
{
    public class Builder
    {
        private string thickness;
        private string color;

        public Builder SetThickness(string thickness)
        {
            this.thickness = thickness;
            return this;
        }

        public Builder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public Dough Build()
        {
            return new Dough(thickness, color);
        }
    }
}