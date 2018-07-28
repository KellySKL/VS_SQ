<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{4C5899EB-C73C-4B6A-890A-63D7C190DB44}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>售后</RootNamespace>
    <AssemblyName>售后</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    <TargetFrameworkProfile />
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <PublishUrl>D:\WebSite\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>1</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <PublishWizardCompleted>true</PublishWizardCompleted>
    <BootstrapperEnabled>true</BootstrapperEnabled>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestCertificateThumbprint>D4DCE1BF6D59D3E251053A7665CA534FB9317D51</ManifestCertificateThumbprint>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestKeyFile>售后_3_TemporaryKey.pfx</ManifestKeyFile>
  </PropertyGroup>
  <PropertyGroup>
    <GenerateManifests>true</GenerateManifests>
  </PropertyGroup>
  <PropertyGroup>
    <SignManifests>false</SignManifests>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="CYTings.Common">
      <HintPath>..\..\..\陈一铤\新架构\CYTings.定时执行\bin\Debug\CYTings.Common.dll</HintPath>
    </Reference>
    <Reference Include="SY">
      <HintPath>..\..\..\陈一铤\新架构\CYTings.定时执行\bin\Debug\SY.dll</HintPath>
    </Reference>
    <Reference Include="SyERP20">
      <HintPath>..\..\..\陈一铤\新架构\CYTings.定时执行\bin\Debug\SyERP20.exe</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Net.Http" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="Xceed.Compression.v5.4">
      <HintPath>..\..\..\Fiddler\Xceed.Compression.v5.4.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="旧件处理.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="旧件处理.Designer.cs">
      <DependentUpon>旧件处理.cs</DependentUpon>
    </Compile>
    <Compile Include="维修完成处理.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="维修完成处理.Designer.cs">
      <DependentUpon>维修完成处理.cs</DependentUpon>
    </Compile>
    <Compile Include="获取入库维修.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include=".Designer.cs">
      <DependentUpon>获取入库维修.cs</DependentUpon>
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <EmbeddedResource Include="旧件处理.resx">
      <DependentUpon>旧件处理.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="维修完成处理.resx">
      <DependentUpon>维修完成处理.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="获取入库维修.resx">
      <DependentUpon>获取入库维修.cs</DependentUpon>
    </EmbeddedResource>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <None Include="App.config" />
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>