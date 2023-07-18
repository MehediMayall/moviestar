namespace MovieStar.Dto
{

    public class ResponseDto
    {
        public string Status { get; set; }
        public string Message { get; set; }

        public object? Data { get; set; }
    }

}