<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="WEB_ConsultaInstructor.MenuPrincipal" %>
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
    <title>Yoga</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:100,200,300,400,500,600,700,800|Old+Standard+TT:400,400i,700" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" rel="stylesheet">
    <link rel="stylesheet" href="CSS/animate.css">
    <link rel="stylesheet" href="CSS/main.css">

</head>

<body>
    <!-- Header section Start -->
    <header class="top">
        <div id="mySidenav" class="sidenav">
            <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
            <a >Home</a>
            <a runat="server" href="~/Consultas.aspx">Consultas</a>
            <a href="">Servicios</a>
            <a href="">Productos</a>
            <a href="">Precios</a>
            <a runat="server" href="~/Logout.aspx">Salir</a>
        </div>
        <!-- Nav section Start -->
        <nav id="navbar">
            <!-- container Start-->
            <div class="container">
                <!--Row Start-->
                <div class="row">
                    <div class="col-lg-5 col-md-5 align-self-center left-side">
                        <p>Haz Yoga, Vive Mejor <span>Llama al 996 053 134</span></p>
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
        <!-- Nav section Ended -->
        <img class="border-img" src="images/border.png" width="100%" alt="">
    </header>
    <!-- Header section Ended-->
    <!-- Banner section Start -->
    <section class="banner-home">
        <!-- Gradient -->
        <div class="gradient"></div>
        <!-- container Start-->
        <div class="container">
            <!--Row Start-->
            <div class="row">
                <div class="col-sm-12">
                    <h1 data-aos="fade-left">Desarrolla Cuerpo y Mente!</h1>
                    <h2 data-aos="fade-left" data-aos-delay="100">Con Yoga, la transformacion definitiva....</h2>
                    <p data-aos="fade-left" data-aos-delay="200"><i class="fa fa-clock-o" aria-hidden="true"></i><span>Estamos abierto las 24 horas</span></p>
                    <p data-aos="fade-left" data-aos-delay="300"><i class="fa fa-phone-square" aria-hidden="true"></i><span>Llama para descuentos especiales</span></p>
                    <p data-aos="fade-left" data-aos-delay="400"><i class="fa fa-envelope" aria-hidden="true"></i><span>fitnessyoga@gmail.com</span></p>
                 <%--   <a data-aos="fade-left" data-aos-delay="500" class="btn btn-success" href="about.html" role="button">our story</a>--%>
                </div>
            </div>
            <!--Row Ended-->
        </div>
        <!-- container Ended-->
    </section>
    <!-- Banner section Ended -->
    <!-- About section start-->
    <section class="about">
        <!-- container Start-->
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-12 heading">
                    <img src="images/leaf.png" alt="">
                    <h2>Yoga como estilo de vida, Cuerpo y Alma</h2>
                    <h3>interesantes publicaciones de blog sobre yoga</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4 col-sm-12 col-12 box-1" data-aos="fade-right" data-aos-duration="400">
                    <div class="circle">
                        <div class="gradient"></div>
                        <div class="circle__inner">
                            <div class="circle__wrapper">
                                <div class="circle__content">
                                    <h4><a href="products.html">Yoga <span>para</span> la vida</a></h4>
                                    <p><a>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's</a></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-12 col-12 box-2" data-aos="fade-up" data-aos-duration="400">
                    <div class="circle">
                        <div class="gradient"></div>
                        <div class="circle__inner">
                            <div class="circle__wrapper">
                                <div class="circle__content">
                                    <h4><a href="products.html">Yoga <span>para</span>la vida</a></h4>
                                    <p><a>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's</a></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-12 col-12 box-3" data-aos="fade-left" data-aos-duration="400">
                    <div class="circle">
                        <div class="gradient"></div>
                        <div class="circle__inner">
                            <div class="circle__wrapper">
                                <div class="circle__content">
                                    <h4><a href="products.html">Yoga <span>para</span>la vida</a></h4>
                                    <p><a>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's</a></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- container Ended-->
    </section>
    <!-- About section Ended-->
    <!-- Services section start-->
    <section class="services">
        <!-- container-fluid Start-->
        <div class="container-fluid">
            <div class="row" data-aos="fade-up" data-aos-duration="400">
                <div class="col-md-3">
                    <figure>
                        <img src="images/services-bg.jpg" alt="The Pulpit Rock">
                    </figure>
                    <div class="gradient"></div>
                </div>
                <div class="col-md-9 right-part">
                    <div class="row">
                        <div class="col-md-12">
                            <h2>El Yoga Es Bueno Para Todos!</h2>
                            <h3>Bueno para todos los hombres, mujeres y niños</h3>
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. a galley of type and scrambled...</p>
                        </div>
                        <div class="col-md-12">
                            <div class="row">
                                <div class="col-xl-4 col-lg-6 col-md-6 col-12 contant-part-1">
                                    <ul>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a>El yoga cura el cancer </a></span></li>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a>El yoga te hace más joven </a></span></li>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a>Te pone en forma</a></span> </li>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a>El yoga es genial!</a></span></li>
                                    </ul>
                                </div>
                              <%--  <div class="col-xl-4 col-lg-6 col-md-6 col-12 contant-part-2">
                                    <ul>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a href="">Yoga Cures Cancer</a></span></li>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a href="services.html">Yogs Makes You Young</a></span></li>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a href="services.html">Get Fit and Well</a></span> </li>
                                        <li><i class="fa fa-envira" aria-hidden="true"></i><span><a href="services.html">Yoga Is Great!</a></span></li>
                                    </ul>
                                </div>--%>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <!-- container-fluid Ended-->
    </section>
    <!-- Services section Ended-->
    <!-- Section-4 section start-->
    <section class="section-4">
        <!-- container-fluid Start-->
       <%-- <div class="container-fluid">
            <div class="row" data-aos="fade-up"  data-aos-duration="400">
                <div class="col-md-9 right-part">
                    <div class="row">
                        <div class="col-md-12 heading">
                            <h2>Control, Body & Mind!</h2>
                            <h3>Good for all men, women and childrens</h3>
                        </div>
                        <div class="col-md-12">
                            <div class="row">
                                <div class="col-md-3 col-6">
                                    <figure>
                                        <img src="images/services-bg.jpg" alt="The Pulpit Rock">
                                    </figure>
                                </div>
                                <div class="col-md-3 col-6">
                                    <figure>
                                        <img src="images/blog-1.jpg" alt="The Pulpit Rock">
                                    </figure>
                                </div>
                                <div class="col-md-3 col-6">
                                    <figure>
                                        <img src="images/blog-2.jpg" alt="The Pulpit Rock">
                                    </figure>
                                </div>
                                <div class="col-md-3 col-6">
                                    <figure>
                                        <img src="images/blog-3.jpg" alt="The Pulpit Rock">
                                    </figure>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. a galley of type and scrambled Lorem Ipsum is simply dummy typesetting industry. a galley of type and scrambled...</p>
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. a galley of type and scrambled......</p>
                            <a href="#" class="btn btn-primary btn-lg active" role="button" aria-pressed="true">Gallery</a>
                            <a href="#" class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">book now</a>
                        </div>
                    </div>

                </div>
                <div class="col-md-3">
                    <figure>
                        <img src="images/section-4-bg.jpg" alt="The Pulpit Rock">
                    </figure>
                    <div class="gradient"></div>
                </div>
            </div>
        </div>--%>
        <!-- container-fluid Ended-->
    </section>
    <!-- Section-4 section Ended-->
    <!-- Blog section start-->
    <section class="blog">
        <!-- container Start-->
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-12 heading">
                    <img src="images/leaf.png" alt="">
                    <h2>Algunos artículos de yoga útiles para ti!</h2>
                    <h3>Bueno para todos los hombres, mujeres y niños</h3>
                </div>
            </div>
            <div class="row" data-aos="fade-up" data-aos-duration="400">
                <div class="col-md-12 col-12">
                    <div class="row">
                        <div class="col-lg-6 col-md-12 col-12">
                            <div class="row">
                                <div class="col-md-4">
                                    <figure>
                                        <a ><img src="images/blog-1.jpg" class="zoom" alt="The Pulpit Rock" width="304" height="228"></a>
                                    </figure>
                                </div>
                                <div class="col-md-8 inner-content">
                                    <h4><a href="blog_single.html">Lorem Ipsum is simply dummy text type and scrambled...</a></h4>
                                    <p><span>Noviembre 23, 2023</span>Subido por <b><a>Bizzee</a></b></p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-12 col-12">
                            <div class="row">
                                <div class="col-md-4">
                                    <figure>
                                        <a><img src="images/blog-2.jpg" alt="The Pulpit Rock" width="304" height="228"></a>
                                    </figure>
                                </div>
                                <div class="col-md-8 inner-content">
                                    <h4><a href="blog_single.html">Lorem Ipsum is simply dummy text type and scrambled...</a></h4>
                                    <p><span>Octubre 13, 2023</span>Subido por <b><a>Bizzee</a></b></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-12 col-12">
                    <div class="row">
                        <div class="col-lg-6 col-md-12 col-12">
                            <div class="row">
                                <div class="col-md-4">
                                    <figure>
                                        <a><img src="images/blog-3.jpg" alt="The Pulpit Rock" width="304" height="228"></a>
                                    </figure>
                                </div>
                                <div class="col-md-8 inner-content">
                                    <h4><a href="blog_single.html">Lorem Ipsum is simply dummy text type and scrambled...</a></h4>
                                    <p><span>Diciembre 12, 2023</span>Subido por <b><a>Bizzee</a></b></p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-12 col-12">
                            <div class="row">
                                <div class="col-md-4">
                                    <figure>
                                        <a><img src="images/blog-4.jpg" alt="The Pulpit Rock" width="304" height="228"></a>
                                    </figure>
                                </div>
                                <div class="col-md-8 inner-content">
                                    <h4><a href="blog_single.html">Lorem Ipsum is simply dummy text type and scrambled...</a></h4>
                                    <p><span>Diciembre 10, 2023</span>Subido por <b><a>Bizzee</a></b></p>
                                    <p></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
         <%--   <div class="row">
                <div class="col-md-12 col-12 button">
                    <a class="btn btn-success" href="blog-page.html" role="button">Gallery</a>
                </div>
            </div>--%>
        </div>
        <!-- container Ended-->
    </section>
    <!-- Blog section Ended-->
    <!-- Footer section start-->
    <footer  class="contact" >
        <!-- Gradient -->
        <div class="gradient"></div>
        <!-- container Start-->
        <div class="container">
            <div class="row" data-aos="fade-up" data-aos-duration="400">
                <div class="col-lg-6 col-md-12 col-12 columns-1">
                    <h2>Nuestra dirección</h2>
                    <address>
                    <p>Av. Miraflores </p>
                    <p>Detrás de parque kennedy</p>
                    <p>Atendemos de : 7:00 am a 7:00 pm</p>
                    <p>Llamanos al : <span>996 053 134</span></p>
                   </address>
                </div>
                <div class="col-lg-1 col-md-12 col-12"></div>
                <div class="col-lg-5 col-md-12 col-12 columns-2">
                    <h2>Contáctanos</h2>
                    <form class="row form-inline">
                        <div class="col-md-6 form-group">
                            <input type="text" class="form-control" placeholder="tu nombre" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <input type="email" class="form-control" placeholder="tu email" required/>
                        </div>
                        <div class="col-md-12 form-group">
                            <textarea class="form-control" placeholder="mensaje" rows="5" cols="70"></textarea>
                        </div>
                        <div class="col-md-12">
                            <button type="submit" class="btn btn-primary">Enviar</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
        <!-- container Ended-->
        <div class="copyright">
            <div class="container">
                <div class="row border-img">
                    <div class="col-md-12">
                        <img src="images/border.png" alt="">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row" data-aos="fade-up" data-aos-duration="400">
                    <div class="col-lg-3 col-md-12">
                        <a href="index.html"><img src="images/footer-logo-bg.png" alt="logo"></a>
                    </div>
                    <div class="col-lg-9 col-md-12 right-part">
                        <ul class="ml-auto">
                           <%-- <li class="nav-item active">
                                <a class="nav-link active" href="index.html">Home <span class="sr-only">(current)</span></a>
                            </li>--%>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" >Servicios</a></li>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" >Productos</a></li>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" >Precios</a></li>
                            <li><a class="hidden-xs">~</a></li>
                            <li class="nav-item"><a class="nav-link" >Blog</a></li>
                        </ul>
                        <p>(C) 2023 Todos los derechos reservados. Diseñado por <a target="_blank">Gianela Quispe</a></p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- Footer section Ended-->
    <!-- Return to Top -->
    <a href="javascript:" id="return-to-top"><i class="fa fa-arrow-up" aria-hidden="true"></i></a>

    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <!-- Custom JavaScript -->
    <script src="js/animate.js"></script>
    <script src="js/custom.js"></script>
</body>

</html>
	
</asp:Content>
