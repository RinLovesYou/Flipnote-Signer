﻿using EncodeAndSign.Data;
using System.Collections.Generic;

namespace EncodeAndSign.Encoder
{
    public class Encoder
    {
        public Flipnote ResultNote { get; set; }
        public Encoder(string[] frames, Flipnote dummy)
        {

            FrameDecoder FrameDecoder = new FrameDecoder(frames);

            Flipnote encoded = Flipnote.New(dummy.Metadata.CurrentAuthorName, dummy.Metadata.CurrentAuthorId, ToDecodedFrame(FrameDecoder.BoolFrames), false);

            //todo: use this for metadata display i guess
            ResultNote = encoded;

            encoded.Save("out/" + encoded.Filename);
        }

        public List<DecodedFrame> ToDecodedFrame(List<bool[,]> input)
        {
            List<DecodedFrame> buffer = new List<DecodedFrame>();

            input.ForEach(frame =>
            {
                if (buffer.Count == 0)
                {
                    DecodedFrame decodedFrame = new DecodedFrame();
                    decodedFrame.SetLayerPixels(1, frame);
                    decodedFrame.CreateThumbnail();
                    buffer.Add(decodedFrame);
                }
                else
                {
                    DecodedFrame decodedFrame = new DecodedFrame();
                    decodedFrame.SetLayerPixels(1, frame);
                    buffer.Add(decodedFrame);
                }

            });
            return buffer;
        }

    }
}