namespace Chinook.Data
{
    partial class Album 
    {
        public string ArtistName { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
