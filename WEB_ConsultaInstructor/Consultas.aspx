﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="WEB_ConsultaInstructor.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!doctype html>
<html>

<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Shoppy</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:100,200,300,400,500,600,700,800|Old+Standard+TT:400,400i,700" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" rel="stylesheet">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/main.css">
    <style>
        .banner-home {
            height: auto;
            padding-top: 200px;
        }

    </style>
</head>

<body>
    <!-- Header section Start-->
    <header class="top">
        <div id="mySidenav" class="sidenav">
            <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
            <a>Home</a>
            <a href="">Consultas</a>
            <a href="">Servicios</a>
            <a href="">Productos</a>
            <a href="">Precios</a>
            <a runat="server" href="~/Logout.aspx" >Salir</a>
        </div>

        <nav id="navbar">
            <!-- container Start-->
            <div class="container">
                <!--Row Start-->
                <div class="row">
                    <div class="col-lg-5 col-md-5 align-self-center left-side">
                        <p>Haz Yoga, Vive Mejor <span>LLAMA AL 996 053 134</span></p>
                    </div>
                    <div class="col-lg-2 col-md-2 col-5 align-self-center logo">
                        <a><img src="images/nav-logo.png" alt="logo"></a>
                    </div>
                    <div class="col-lg-5 col-md-5 col-7 align-self-center right-side">
                        <div class="social-icons square">
                            <!-- Page Content -->
                            <div id="page-content-wrapper">
                                <span class="slide-menu" onclick="openNav()"><i class="fa fa-bars" aria-hidden="true"></i></span>
                            </div>
                        </div>
                        <div class="social-icons another">
                            <i class="fa fa-facebook-official" aria-hidden="true"></i>
                            <i class="fa fa-twitter" aria-hidden="true"></i>
                            <i class="fa fa-pinterest" aria-hidden="true"></i>
                            <i class="fa fa-youtube" aria-hidden="true"></i>
                        </div>
                    </div>
                </div>
                <!--Row Ended-->
            </div>
            <!-- container Ended-->
        </nav>
        <img class="border-img" src="images/border.png" width="100%" alt="">
    </header>
    <!-- Header section Ended-->

    <section class="banner-another ">
        <!-- Banner section Start-->
    </section>
    <!-- services section Start -->
  <section id="">
    
       <div class="container">
       <h2 data-aos="fade-up" data-aos-delay="200">Servicios de Consulta</h2>
       <div>
      &nbsp;<table>
           <tr>
               <td >
                   <figure>
                       <img src="images/Web-Design.jpg" alt="Web Design" >
                   </figure>
               </td>
               <td>
                   <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple">
                       <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                       <Nodes>
                           <asp:TreeNode Text="Consultas" Value="Consultas">
                               <asp:TreeNode NavigateUrl="~/Consultas/ConsultarReservas.aspx" Text="Consulta Reserva Por Cliente" Value="Consulta Reserva Por Cliente"></asp:TreeNode>
                               <asp:TreeNode NavigateUrl="~/Consultas/WEB_ConsultaInstructor.aspx" Text="Consulta Clase Programada Por Instructor" Value="Consulta Clase Programada Por Cliente"></asp:TreeNode>
                           </asp:TreeNode>
                       </Nodes>
                       <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
                       <ParentNodeStyle Font-Bold="False" />
                       <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                   </asp:TreeView>
 
               </td>
               </tr>
             </table>
               &nbsp;
       
       </div>
  </div>
          
    </section>
   
    <!-- services section Ended -->

    <footer class="contact">
        <div class="gradient"></div>
        <div class="copyright">
            <div class="container">
                <div class="row border-img">
                    <div class="col-md-12">
                        <img src="images/border.png" alt="">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-12">
                        <a href="index.html"><img src="images/footer-logo-bg.png" alt="logo"></a>
                    </div>
                    <div class="col-lg-9 col-md-12 right-part">
                        <ul class="ml-auto">
                           <%-- <li class="nav-item active">
                                <a class="nav-link active" href="index.html">Home <span class="sr-only">(current)</span></a>
                            </li>--%>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" href="services.html">Servicios</a></li>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" href="products.html">Productos</a></li>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" href="rates.html">Precios</a></li>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" href="blog-page.html">Blog</a></li>
                        </ul>
                        <p>(C) 2023 Todos los derechos reservados. Diseñado por <a href="https://www.template.net/editable/websites/html5" target="_blank">Gianela Quispe</a></p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- Return to Top -->
    <a href="javascript:" id="return-to-top"><i class="fa fa-arrow-up" aria-hidden="true"></i></a>

    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <!-- Custom JavaScript -->
    <script src="js/animate.js"></script>
    <script src="js/custom.js"></script>
    <script>


    </script>
</body>

</html>





</asp:Content>
