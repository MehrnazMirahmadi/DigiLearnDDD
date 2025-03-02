using DigiLearn.Domain.Exceptions.CourseManagementExceptions;

namespace DigiLearn.Domain.ValueObjects
{
    public record VideoUrl
    {
        public string Value { get; }

        public VideoUrl(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new VideoUrlNullOrEmptyException();
            }

            if (!value.EndsWith(".mp4"))
            {
                throw new InvalidVideoExtensionException();
            }

            Value = value;
        }

        public static implicit operator string(VideoUrl videoUrl) => videoUrl.Value;
        public static implicit operator VideoUrl(string videoUrl) => new(videoUrl);
    }
}
