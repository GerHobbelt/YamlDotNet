﻿// This file is part of YamlDotNet - A .NET library for YAML.
// Copyright (c) Antoine Aubry and contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using Microsoft.CodeAnalysis;

namespace YamlDotNet.Analyzers.StaticGenerator
{
    public abstract class File
    {
        private readonly Action<string> _write;
        private readonly Action _indent;
        private readonly Action _unindent;

        public File(Action<string> write, Action indent, Action unindent, GeneratorExecutionContext context)
        {
            _write = write;
            _indent = indent;
            _unindent = unindent;
        }

        public void Write(string text)
        {
            _write(text);
        }

        public void Indent()
        {
            _indent();
        }

        public void UnIndent()
        {
            _unindent();
        }

        public abstract void Write(ClassSyntaxReceiver classSyntaxReceiver);
    }
}
