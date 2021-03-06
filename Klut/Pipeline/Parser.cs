﻿using Klut.Streams;
using Klut.Tokens;

namespace Klut.Pipeline
{
    class Parser
    {
        public TokenStream InputStream { get; private set; }

        public ParseStream OutputStream { get; private set; }

        public Parser( TokenStream inputStream )
        {
            InputStream = inputStream;
            InputStream.ItemsAdded += inputStream_ItemsAdded;
            InputStream.EndOfStreamReceived += InputStream_EndOfStreamReceived;
            OutputStream = new ParseStream();
        }

        private void inputStream_ItemsAdded( object sender, TokenStream.ItemsAddedEventArgs eventArgs )
        {
            for ( int i = 0; i < eventArgs.Count; i++ )
            {
                Token inputToken = InputStream.Receive();

                // debug
                System.Console.WriteLine( inputToken );

                // todo: implement
            }
        }

        private void InputStream_EndOfStreamReceived( object sender,
            TokenStream.EndOfStreamReceivedEventArgs eventArgs )
        {
            // todo: implement
        }
    }
}
