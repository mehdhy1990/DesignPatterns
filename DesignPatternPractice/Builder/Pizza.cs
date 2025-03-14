namespace DesignPatternPractice.Builder;

public record Pizza(string sauce, Dough dough)
{
    public class Builder
    {
        public string Sauce { get; set; } = string.Empty;
        public Dough Dough { get; set; } 

        public Builder SetSauce(string sauce)
        {
            this.Sauce = sauce;
            return this;
        }

        public Builder SetDough(Func<Dough> dough)
        {
           var newdough = dough();
           this.Dough = newdough;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(Sauce, Dough);
        }
    }
}