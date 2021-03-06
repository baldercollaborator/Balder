﻿using System;
using Balder.Core.Services;

namespace Balder.Core.Tests.Fakes
{
	public class TargetDevice : ITargetDevice
	{
		public TargetDevice()
		{
			Display = new Display();
		}

		public string Name { get { return "Mock Target Device"; } }
		public string Description { get { return string.Empty; } }

		public IDisplay Display { get; private set; }
		public Type GeometryContextType { get { return typeof(GeometryContext); } }
		public Type ImageContextType { get { return typeof(ImageContext); } }
		public Type SpriteContextType { get { return typeof (SpriteContext); } }
		public Type GameType { get; set; }
		public Type FileLoaderType { get { return typeof(FileLoader); } }
		public void RegisterAssetLoaders(IAssetLoaderService assetLoaderService)
		{
			
		}
	}
}
