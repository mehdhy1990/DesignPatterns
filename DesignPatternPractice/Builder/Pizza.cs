namespace DesignPatternPractice.Builder;

public record Pizza(string sauce, string dough)
{
    public class Builder
    {
        public string Sauce { get; set; } = string.Empty;
        public string Dough { get; set; } = string.Empty;

        public Builder SetSauce(string sauce)
        {
            this.Sauce = sauce;
            return this;
        }

        public Builder SetDough(string dough)
        {
            this.Dough = dough;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(Sauce, Dough);
        }
    }
}