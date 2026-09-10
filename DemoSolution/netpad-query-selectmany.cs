// selectmany

var players = new List<Player>
{
    new() { Name = "Richard", Cards = [ new() { Value = 4, Suit = "hearts" }, new() { Value = 4, Suit = "diamond" }] },
    new() { Name = "Daan", Cards = [ new() { Value = 6, Suit = "spade" }, new() { Value = 9, Suit = "spade" }] },
    new() { Name = "JP", Cards = [ new() { Value = 7, Suit = "club" }, new() { Value = 8, Suit = "club" }] }
};
players.SelectMany(x => x.Cards).Dump();


class Player
{
    public string Name { get; set; }
    public Card[] Cards { get; set; } = [];
}
class Card
{
    public int Value { get; set; }
    public string Suit { get; set; }
}
