namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse guestResponse)
        {
            Console.WriteLine(responses);
            responses.Add(guestResponse);
        }
    }
}
