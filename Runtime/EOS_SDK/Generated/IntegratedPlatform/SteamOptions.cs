// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.IntegratedPlatform
{
	/// <summary>
	/// Required initialization options to use with <see cref="Options" /> for Steam.
	/// Steamworks API needs to be at least v1.13
	/// Steam Sanitization requires at least v1.45
	/// Starting Steamworks v1.58a onwards, SteamApiInterfaceVersionsArray is required when <see cref="IntegratedPlatformManagementFlags.LibraryManagedBySDK" /> is set.
	/// <seealso cref="Options" />
	/// </summary>
	public struct SteamOptions
	{
		/// <summary>
		/// Usage of this parameter is dependent on the specified <see cref="IntegratedPlatformManagementFlags" />.
		/// 
		/// Optional with <see cref="IntegratedPlatformManagementFlags.LibraryManagedByApplication" />.
		/// Set to override the loaded library basename, or use <see langword="null" /> to assume the default basename by platform:
		/// 
		/// - Linux: libsteam_api.so,
		/// - macOS: libsteam_api.dylib,
		/// - Windows 32-bit: steam_api.dll,
		/// - Windows 64-bit: steam_api64.dll.
		/// 
		/// Required with <see cref="IntegratedPlatformManagementFlags.LibraryManagedBySDK" />.
		/// Set to a fully qualified file path to the Steamworks SDK runtime library on disk.
		/// </summary>
		public Utf8String OverrideLibraryPath { get; set; }

		/// <summary>
		/// Used to specify the major version of the Steam SDK your game is compiled against, e.g.:
		/// 
		/// Options.SteamMajorVersion = 1;
		/// </summary>
		public uint SteamMajorVersion { get; set; }

		/// <summary>
		/// Used to specify the minor version of the Steam SDK your game is compiled against, e.g.:
		/// 
		/// Options.SteamMinorVersion = 58;
		/// </summary>
		public uint SteamMinorVersion { get; set; }

		/// <summary>
		/// A pointer to a series of null terminated steam interface version names supported by the current steam dll.
		/// 
		/// This field is only required when the Integrated Platform Management flags has <see cref="IntegratedPlatformManagementFlags.LibraryManagedBySDK" /> set. Else must be set to <see langword="null" />.
		/// 
		/// Starting v1.58 the Steam initialization API requires this new field during initialization for version check validations.
		/// 
		/// Note: The pointer must be valid until after the execution of the <see cref="IntegratedPlatformOptionsContainer.Add" /> method.
		/// 
		/// This value must be constructed from the corresponding steam_api.h header of the steam dll version that is shipped with the game.
		/// In the steam_api.h header, look for SteamAPI_InitEx() and copy the value of pszInternalCheckInterfaceVersions as it is.
		/// 
		/// For example in v1.58a its this:
		/// const <see cref="byte" /> SteamInterfaceVersionsArray[] =
		/// STEAMUTILS_INTERFACE_VERSION "\0"
		/// STEAMNETWORKINGUTILS_INTERFACE_VERSION "\0"
		/// ...
		/// STEAMUSER_INTERFACE_VERSION "\0"
		/// STEAMVIDEO_INTERFACE_VERSION "\0"
		/// "\0";
		/// </summary>
		public Utf8String SteamApiInterfaceVersionsArray { get; set; }

		/// <summary>
		/// Size of the SteamApiInterfaceVersionsArray in bytes. Cannot exceed <see cref="IntegratedPlatformInterface.SteamMaxSteamapiinterfaceversionsarraySize" />.
		/// 
		/// This field is only required when the Integrated Platform Management flags has <see cref="IntegratedPlatformManagementFlags.LibraryManagedBySDK" /> set. Else must be set to 0.
		/// 
		/// Note: Since SteamInterfaceVersionsArray contains a series of null terminated strings, please ensure that strlen() is NOT used to calculate this field.
		/// For instance, you can use the following to get the array length:
		/// const <see cref="byte" /> SteamInterfaceVersionsArray[] =
		/// STEAMUTILS_INTERFACE_VERSION "\0"
		/// STEAMNETWORKINGUTILS_INTERFACE_VERSION "\0"
		/// ...
		/// STEAMVIDEO_INTERFACE_VERSION "\0"
		/// "\0";
		/// 
		/// <see cref="uint" /> SteamApiInterfaceVersionsArrayBytes = sizeof(SteamApiInterfaceVersionsArray) // Note: sizeof() takes into account the last "\0" of the string literal;
		/// </summary>
		public uint SteamApiInterfaceVersionsArrayBytes { get; set; }

		internal void Set(ref SteamOptionsInternal other)
		{
			OverrideLibraryPath = other.OverrideLibraryPath;
			SteamMajorVersion = other.SteamMajorVersion;
			SteamMinorVersion = other.SteamMinorVersion;
			SteamApiInterfaceVersionsArray = other.SteamApiInterfaceVersionsArray;
			SteamApiInterfaceVersionsArrayBytes = other.SteamApiInterfaceVersionsArrayBytes;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SteamOptionsInternal : IGettable<SteamOptions>, ISettable<SteamOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_OverrideLibraryPath;
		private uint m_SteamMajorVersion;
		private uint m_SteamMinorVersion;
		private System.IntPtr m_SteamApiInterfaceVersionsArray;
		private uint m_SteamApiInterfaceVersionsArrayBytes;

		public Utf8String OverrideLibraryPath
		{
			get
			{
				Utf8String value;
				Helper.Get(m_OverrideLibraryPath, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_OverrideLibraryPath);
			}
		}

		public uint SteamMajorVersion
		{
			get
			{
				return m_SteamMajorVersion;
			}

			set
			{
				m_SteamMajorVersion = value;
			}
		}

		public uint SteamMinorVersion
		{
			get
			{
				return m_SteamMinorVersion;
			}

			set
			{
				m_SteamMinorVersion = value;
			}
		}

		public Utf8String SteamApiInterfaceVersionsArray
		{
			get
			{
				Utf8String value;
				Helper.Get(m_SteamApiInterfaceVersionsArray, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_SteamApiInterfaceVersionsArray);
			}
		}

		public uint SteamApiInterfaceVersionsArrayBytes
		{
			get
			{
				return m_SteamApiInterfaceVersionsArrayBytes;
			}

			set
			{
				m_SteamApiInterfaceVersionsArrayBytes = value;
			}
		}

		public void Set(ref SteamOptions other)
		{
			m_ApiVersion = IntegratedPlatformInterface.SteamOptionsApiLatest;
			OverrideLibraryPath = other.OverrideLibraryPath;
			SteamMajorVersion = other.SteamMajorVersion;
			SteamMinorVersion = other.SteamMinorVersion;
			SteamApiInterfaceVersionsArray = other.SteamApiInterfaceVersionsArray;
			SteamApiInterfaceVersionsArrayBytes = other.SteamApiInterfaceVersionsArrayBytes;
		}

		public void Set(ref SteamOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = IntegratedPlatformInterface.SteamOptionsApiLatest;
				OverrideLibraryPath = other.Value.OverrideLibraryPath;
				SteamMajorVersion = other.Value.SteamMajorVersion;
				SteamMinorVersion = other.Value.SteamMinorVersion;
				SteamApiInterfaceVersionsArray = other.Value.SteamApiInterfaceVersionsArray;
				SteamApiInterfaceVersionsArrayBytes = other.Value.SteamApiInterfaceVersionsArrayBytes;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_OverrideLibraryPath);
			Helper.Dispose(ref m_SteamApiInterfaceVersionsArray);
		}

		public void Get(out SteamOptions output)
		{
			output = new SteamOptions();
			output.Set(ref this);
		}
	}
}