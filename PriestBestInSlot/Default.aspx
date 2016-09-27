<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PriestBestInSlot.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        SHADOW  HowToPriest - Heroic Combined<br />
    
        <asp:TextBox ID="TB_HTP_Mythic_Combined" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Heroic Combined, NO Crafted<br />
    
        <asp:TextBox ID="TB_HTP_Mythic_Combined_No_Crafted" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Heroic S2M<br />
    
        <asp:TextBox ID="TB_HTP_Mythic_AS" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Heroic LotV/MSp<br />
    
        <asp:TextBox ID="TB_HTP_Mythic_CoP" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Pre Raid Combined<br />
    
        <asp:TextBox ID="TB_HTP_PreRaid_Combined" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Crafted Gear Only<br />
    
        <asp:TextBox ID="TB_HTP_Crafted" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Mythic Clarity of Power 1 Target<br />
    
        <asp:TextBox ID="TB_HTP_Mythic_CoP1Tar" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />
        SHADOW  HowToPriest - Mythic Void Entropy<br />
    
        <asp:TextBox ID="TB_HTP_Mythic_VEnt" runat="server" Height="200px" 
            TextMode="MultiLine" Width="670px"></asp:TextBox>
    
        <br />
        <br />

    
    
        <asp:SqlDataSource ID="SDS_ItemsList" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [Items] WHERE ([ItemSlot] = ?) AND Patch070003 = YES">
            <SelectParameters>
                <asp:Parameter Name="ItemSlot" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <asp:SqlDataSource ID="SDS_ItemsList_Preraid" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [Items] WHERE ([ItemSlot] = ?) AND Patch070003 = YES
 AND
(
 (SourceType IS NULL OR SourceType = '5N' OR SourceType = '5H' OR SourceType = '5M' OR SourceType = 'TW' OR SourceType = 'EMP' OR SourceType = '')
OR
 (SourceType = 'RF')
OR
 (SourceType = 'RM' OR SourceType = 'RH' OR SourceType = 'RN')
OR
 (SourceType &lt;&gt; 'RM' AND SourceType &lt;&gt; 'RH' AND SourceType &lt;&gt; 'RN')
)
AND
(
 (ItemType &lt;&gt; 'Crafted') OR (ItemType = 'Crafted' AND [ItemSlot] = 'Trinket')
)">
            <SelectParameters>
                <asp:Parameter Name="ItemSlot" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <asp:SqlDataSource ID="SDS_Highmaul" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [Items] WHERE ([ItemSlot] = ?) AND Patch070003 = YES
AND (NOT
([Source] LIKE '%Blackrock Foundry%')
)
AND
(
(ItemType &lt;&gt; 'Crafted') OR (ItemType = 'Crafted' AND [ItemSlot] = 'Trinket')
)
ORDER BY [Source] ASC">
            <SelectParameters>
                <asp:Parameter Name="ItemSlot" Type="String" />
            </SelectParameters> 
        </asp:SqlDataSource>
    
        <asp:SqlDataSource ID="SDS_Crafted" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [Items] WHERE ([ItemSlot] = ?) AND Patch070003 = YES
 AND
(
 (ItemType = 'Crafted')
)">
            <SelectParameters>
                <asp:Parameter Name="ItemSlot" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <asp:SqlDataSource ID="SDS_NoCrafted" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [Items] WHERE ([ItemSlot] = ?) AND Patch070003 = YES
 AND
(
 (ItemType &lt;&gt; 'Crafted') OR (ItemType = 'Crafted' AND [ItemSlot] = 'Trinket')
)">
            <SelectParameters>
                <asp:Parameter Name="ItemSlot" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
 
 
    
        <asp:SqlDataSource ID="SDS_All" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [Items]">
        </asp:SqlDataSource>    
    </div>
    </form>
</body>
</html>
