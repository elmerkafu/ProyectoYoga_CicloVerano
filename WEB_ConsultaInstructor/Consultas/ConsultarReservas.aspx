<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultarReservas.aspx.cs" Inherits="WEB_ConsultaInstructor.Consultas.ConsultarReservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="containers">
      <div class="col-md-7 col-lg-8 padding-top"; >
         <h4 class="mb-3">Reservas del Cliente</h4>
      </div>
     <div class="row g-3" Width="300px">
         <div class="col-4 col-sm-3">
             <p class="labelContenido">Ingrese código cliente:</p>                
         </div>
         <div class="col-4 col-sm-2">
             <asp:TextBox ID="txtCod" runat="server" Width="85px" class="form-control"></asp:TextBox>
         </div>
         <div class="col-4 col-sm-2">
             <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/lupa.png" Width="18px" Height="18" OnClick="btnBuscar_Click" />
         </div>
         <div class="row g-3">
             <div col="col-12">
                 <label class="form-label">Nombres:</label><asp:TextBox ID="txtNombre" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
             </div>
              <div class="col-sm-6">
                    <label class="form-label">Apellidos:</label>
                     <asp:TextBox ID="txtApellido" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
              </div> 

               <div class="col-sm-6">
                 <label class="form-label">Correo</label>
                  <div class="group-text">
                 <span class="input-group-text">@</span>
                <asp:TextBox ID="txtCorreo" runat="server" ReadOnly="True" class="form-control"></asp:TextBox>
                 </div>                    
                 </div>
             <div class="col-sm-6">
                 <label class="form-label">Dirección:</label>
                 <asp:TextBox ID="txtDireccion" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
             </div>                
             <div class="col-sm-6">
                 <label class="form-label">DNI:</label>
                 <asp:TextBox ID="txtDNI" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
             </div>
             <div class="col-sm-6">
                 <label class="form-label">Teléfono:</label>
                 <asp:TextBox ID="txtTelef" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
             </div>  
              <div class="col-sm-6">
                <label class="form-label">Departamento_Provincia_Distrito:</label>
                <asp:TextBox ID="txtUbigeo" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
              </div>  
           
             <div class="col-sm-6">                     
                 <label class="form-label">Fecha inicio:</label>
                 <asp:TextBox ID="txtFI" runat="server" class="form-control"></asp:TextBox>
             </div>
             <div class="col-sm-6">
                 <label class="form-label">Fecha fin:</label>
                 <asp:TextBox ID="txtFF" runat="server" class="form-control"></asp:TextBox>
             </div>

             <div>
                  <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores" Width="300px"></asp:Label>
                  <br />
             </div>
             <div>

                 <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas.aspx">retornar</asp:HyperLink>
             </div>
             <div>
                  <asp:Button ID="btnConsultar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnConsultar_Click" Text="Consultar" />
             </div>
             <div Height="40px">
                 <br />       
             </div>
         </div>
     </div>
 </div>   
 <div class="container" >
        <div class="row">
    <asp:GridView ID="grvReservas" runat="server" AutoGenerateColumns="False" class="table table-success table-striped table-bordered" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" ShowHeaderWhenEmpty="True" Width="1278px" HorizontalAlign="Left" OnSelectedIndexChanged="grvReservas_SelectedIndexChanged" BackColor="#CCCCCC" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="Cod_resv" HeaderText="Código" />
            <asp:BoundField DataField="Fec_resv" DataFormatString="{0:d}" HeaderText="Fecha Reserva">
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="EstRev" HeaderText="Estado">
            </asp:BoundField>
            <asp:BoundField DataField="Observacion" HeaderText="Observacion">
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
            <br />
            
</div>
 </div>


</asp:Content>
