using encoder_decoder.Classes;
using Xunit;

namespace EncoderDecoder.Tests;

public class MessageEncoderTests
{
    [Fact]
    public void Encode_ReplacesSupportedCharacters()
    {
        string result = MessageEncoder.Encode("AEIOS");

        Assert.Equal("@3!0$", result);
    }

    [Fact]
    public void Encode_LeavesOtherCharactersUnchanged()
    {
        string result = MessageEncoder.Encode("BCDF");

        Assert.Equal("BCDF", result);
    }
}

public class MessageDecoderTests
{
    [Fact]
    public void Decode_ReplacesEncodedCharacters()
    {
        string result = MessageDecoder.Decode("@3!0$");

        Assert.Equal("AEIOS", result);
    }

    [Fact]
    public void Decode_LeavesOtherCharactersUnchanged()
    {
        string result = MessageDecoder.Decode("BCDF");

        Assert.Equal("BCDF", result);
    }
}