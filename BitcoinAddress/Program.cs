using System;
using NBitcoin;

namespace BitcoinAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Key privateKey = new Key(); //generate a random private key

            //from the private key, we use a one-way cryptography function, to generate a public key.
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(publicKey);  //03d15421b7301726d1576b3b75c3d986c77b75d7126bbc3cca176f869777070e85

            //you can easily get your bitcoin address from your public key and the network on which this address should be used
            Console.WriteLine(publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main));  //1ANN5FJ1DXuqSJJwHypomjyGwdLbAAHb5i
            Console.WriteLine(publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.TestNet));  //mptKNJNz2ZM6DQnZ1YoBbfBbocwJ4uhSqQ

            var publicKeyHash = publicKey.Hash;
            Console.WriteLine(publicKey);  //0319330d98c1ec6e7683640a9957d453cbb7088d01bd7005e074e8ccf8e5709f83
            var mainNetAddress = publicKeyHash.GetAddress(Network.Main);
            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);

            Console.WriteLine(mainNetAddress); // 1MYHsmESjyjdxMFtvuLB77mqbiqzr3ghoZ
            Console.WriteLine(testNetAddress); // n24FApKRZ1AtjTjWeUJYw2zATiShhnMWU9
        }
    }
}
