<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="12008004">
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="DataReceived_CB.vi" Type="VI" URL="../DataReceived_CB.vi"/>
		<Item Name="FanGraph.vi" Type="VI" URL="../FanGraph.vi"/>
		<Item Name="Globals.vi" Type="VI" URL="../Globals.vi"/>
		<Item Name="Leddar2LabVIEW.vi" Type="VI" URL="../Leddar2LabVIEW.vi"/>
		<Item Name="LeddarClose.vi" Type="VI" URL="../LeddarClose.vi"/>
		<Item Name="LeddarOpen.vi" Type="VI" URL="../LeddarOpen.vi"/>
		<Item Name="LeddarRead.vi" Type="VI" URL="../LeddarRead.vi"/>
		<Item Name="Seg2Ang.vi" Type="VI" URL="../Seg2Ang.vi"/>
		<Item Name="SingleExecution.vi" Type="VI" URL="../SingleExecution.vi"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
				<Item Name="subDisplayMessage.vi" Type="VI" URL="/&lt;vilib&gt;/express/express output/DisplayMessageBlock.llb/subDisplayMessage.vi"/>
				<Item Name="subTimeDelay.vi" Type="VI" URL="/&lt;vilib&gt;/express/express execution control/TimeDelayBlock.llb/subTimeDelay.vi"/>
			</Item>
			<Item Name="LeddarNET2.dll" Type="Document" URL="/C/Program Files/LeddarTech/xtec/LeddarNET2.dll"/>
			<Item Name="mscorlib" Type="VI" URL="mscorlib">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
