using Shadowsocks.Std.Encryption.Parameters;

namespace Shadowsocks.Std.Encryption.Stream
{
    public abstract class StreamEncryptor : EncryptorBase<StreamEncryptionParameters>
    {
        protected byte[] _encryptIV;
        protected byte[] _decryptIV;

        protected StreamEncryptor(string passwd, StreamEncryptionParameters parameters) : base(passwd, parameters)
        {

        }

        protected virtual void InitIv(ref byte[] iv)
        {
            _random.NextBytes(iv);
        }
    }
}