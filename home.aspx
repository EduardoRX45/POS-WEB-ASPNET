<%@ Page Language="VB" AutoEventWireup="false" CodeFile="home.aspx.vb" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cerrajería Cardoso - Servicio 24/7</title>
    <!-- Bootstrap 5 -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome para iconos -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
    <!-- Animate.css para animaciones -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css">
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;700&family=Poppins:wght@600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="styles.css">
    <link href="css/style_home.css" rel="stylesheet" runat="server" media="screen" />
</head>
<body>
  <!-- WhatsApp Float Button -->
  <a href="https://wa.me/527221243028?text=Hola,%20necesito%20información%20sobre%20sus%20servicios" class="btn btn-whatsapp animate__animated animate__bounceIn animate__delay-2s">
    <i class="fab fa-whatsapp fa-2x"></i>
  </a>

  <!-- Navbar -->
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
  <div class="container">
    <a class="navbar-brand d-flex align-items-center" href="login.html">
      <img src="logo.png" alt="Cerrajería Cardoso" height="40" class="me-2">
    </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
      <span class="navbar-toggler-icon"></span>
    </button>
      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav ms-auto">
          <li class="nav-item">
            <a class="nav-link active" href="#inicio">Inicio</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#servicios">Servicios</a>
          </li>
        <li class="nav-item">
            <a class="nav-link" href="prods.aspx">Productos</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#nosotros">Nosotros</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#testimonios">Testimonios</a>
          </li>
        <li class="nav-item">
            <a class="nav-link" href="#contacto">Contacto</a>
          </li>
        </ul>
        <div class="ms-lg-3 mt-3 mt-lg-0">
          <a href="login.aspx" class="btn btn-outline-light">Acceder</a>
        </div>
      </div>
    </div>
  </nav>

  <!-- Hero Section -->

  <section id="inicio" class="hero-section d-flex align-items-center">
    <div class="container">
      <div class="row">
        <div class="col-lg-8 mx-auto text-center animate__animated animate__fadeIn">
          <h1 class="display-1 fw-bold mb-4">Cerrajería Cardoso</h1>
          <p class="lead mb-5">Soluciones rápidas y confiables para emergencias de cerrajería en hogares, negocios y vehículos.</p>
          <div class="d-flex justify-content-center gap-3">
            <a href="tel:+527221243028" class="btn btn-primary btn-lg px-4">
              <i class="fas fa-phone me-2"></i>Llamar ahora
            </a>
            <a href="#contacto" class="btn btn-outline-light btn-lg px-4">
              <i class="fas fa-envelope me-2"></i>Contactar
            </a>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Emergency Banner -->
  <div class="bg-danger text-white py-3">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-md-8">
          <h5 class="mb-0"><i class="fas fa-exclamation-triangle me-2"></i>¿Emergencia? ¡Llámanos ahora mismo! Respuesta en menos de 30 minutos.</h5>
        </div>
        <div class="col-md-4 text-md-end mt-2 mt-md-0">
          <a href="tel:+527221243028" class="btn btn-light btn-sm">
            <i class="fas fa-phone me-1"></i>+52 722-124-3028
          </a>
        </div>
      </div>
    </div>
  </div>

  <!-- Servicios -->
<section id="servicios" class="py-5 bg-light">
  <div class="container">
    <div class="row justify-content-center mb-5">
      <div class="col-lg-8 text-center">
        <h2 class="fw-bold mb-3">Nuestros Servicios</h2>
        <p class="lead text-muted">Ofrecemos soluciones completas para todas tus necesidades de cerrajería con profesionalismo y rapidez.</p>
      </div>
    </div>
    
    <form id="form1" runat="server">
        <div class="row g-4">
            <asp:Repeater ID="repServicios" runat="server">
                <ItemTemplate>
                    <div class="col-md-6 col-lg-4">
                        <div class="service-card bg-white p-4 h-100">
                            <%--<div class="service-icon text-center"><img src='<%#Eval("Imagen") %>' /></div>--%>
                            <h4 class="text-center mb-3"><%# Eval("Nombre") %></h4>
                            <p class="text-muted"><%# Eval("Descripcion") %></p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>


  </div>
</section>


  <!-- About Us -->
  <section id="nosotros" class="py-5">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6 mb-4 mb-lg-0">
          <h2 class="fw-bold mb-4">Cerrajería Cardoso: Confianza y Experiencia</h2>
          <p class="lead">Más de 15 años brindando soluciones de cerrajería en la Ciudad de México y área metropolitana.</p>
          <p>Somos una empresa familiar con décadas de experiencia en el sector de la cerrajería y seguridad. Altamente capacitados para atender tus emergencias.</p>
          <div class="row mt-4">
            <div class="col-6">
              <div class="d-flex align-items-center mb-3">
                <div class="bg-primary rounded-circle p-2 me-3 text-white">
                  <i class="fas fa-check"></i>
                </div>
                <div>
                  <h5 class="mb-0">Certificados</h5>
                </div>
              </div>
            </div>
            <div class="col-6">
              <div class="d-flex align-items-center mb-3">
                <div class="bg-primary rounded-circle p-2 me-3 text-white">
                  <i class="fas fa-clock"></i>
                </div>
                <div>
                  <h5 class="mb-0">Rápida respuesta</h5>
                </div>
              </div>
            </div>
            <div class="col-6">
              <div class="d-flex align-items-center mb-3">
                <div class="bg-primary rounded-circle p-2 me-3 text-white">
                  <i class="fas fa-shield-alt"></i>
                </div>
                <div>
                  <h5 class="mb-0">Seguridad garantizada</h5>
                </div>
              </div>
            </div>
            <div class="col-6">
              <div class="d-flex align-items-center mb-3">
                <div class="bg-primary rounded-circle p-2 me-3 text-white">
                  <i class="fas fa-dollar-sign"></i>
                </div>
                <div>
                  <h5 class="mb-0">Precios justos</h5>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="ratio ratio-16x9">
           <iframe class="rounded" 
        width="100%" height="315" 
        src="https://www.youtube.com/embed/fTv6kTWnHfc" 
        title="YouTube video" 
        frameborder="0" 
        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" 
        allowfullscreen>
</iframe>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Stats -->
  <section class="py-5 bg-primary text-white">
    <div class="container">
      <div class="row text-center">
        <div class="col-md-3 col-6 mb-4 mb-md-0">
          <div class="display-4 fw-bold">15+</div>
          <p class="mb-0">Años de experiencia</p>
        </div>
        <div class="col-md-3 col-6 mb-4 mb-md-0">
          <div class="display-4 fw-bold">24/7</div>
          <p class="mb-0">Disponibilidad</p>
        </div>
        <div class="col-md-3 col-6">
          <div class="display-4 fw-bold">5,000+</div>
          <p class="mb-0">Clientes satisfechos</p>
        </div>
        <div class="col-md-3 col-6">
          <div class="display-4 fw-bold">30'</div>
          <p class="mb-0">Tiempo promedio de respuesta</p>
        </div>
      </div>
    </div>
  </section>

  <!-- Testimonios -->
  <section id="testimonios" class="py-5 bg-light">
    <div class="container">
      <div class="row justify-content-center mb-5">
        <div class="col-lg-8 text-center">
          <h2 class="fw-bold mb-3">Lo que dicen nuestros clientes</h2>
          <p class="lead text-muted">Testimonios reales de personas que han confiado en nuestros servicios.</p>
        </div>
      </div>
      
      <div class="row g-4">
        <div class="col-md-4">
          <div class="testimonial-card bg-white p-4 h-100">
            <div class="d-flex align-items-center mb-3">
              <img src="https://randomuser.me/api/portraits/women/32.jpg" class="rounded-circle me-3" width="60" alt="Cliente">
              <div>
                <h5 class="mb-0">Diana Romero </h5>
                <div class="text-warning">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                </div>
              </div>
            </div>
            <p class="mb-0">"Quedé impresionada con la rapidez del servicio. Llegaron en menos de 20 minutos y abrieron mi puerta sin dañar la cerradura. ¡Totalmente recomendados!"</p>
          </div>
        </div>
        
        <div class="col-md-4">
          <div class="testimonial-card bg-white p-4 h-100">
            <div class="d-flex align-items-center mb-3">
              <img src="https://randomuser.me/api/portraits/men/45.jpg" class="rounded-circle me-3" width="60" alt="Cliente">
              <div>
                <h5 class="mb-0">Alexis Hernandez</h5>
                <div class="text-warning">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                </div>
              </div>
            </div>
            <p class="mb-0">"Excelente servicio. Tuve una emergencia y me resolvieron el problema en minutos, con precios justos."</p>
          </div>
        </div>
        
        <div class="col-md-4">
          <div class="testimonial-card bg-white p-4 h-100">
            <div class="d-flex align-items-center mb-3">
              <img src="https://randomuser.me/api/portraits/women/68.jpg" class="rounded-circle me-3" width="60" alt="Cliente">
              <div>
                <h5 class="mb-0">Laura González</h5>
                <div class="text-warning">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
                </div>
              </div>
            </div>
            <p class="mb-0">"Instalaron nuevas cerraduras de alta seguridad en mi negocio. Fue muy profesional y me explicó todo el proceso. Muy contenta con el resultado."</p>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Contacto -->
  <section id="contacto" class="py-5">
    <div class="container">
      <div class="row justify-content-center mb-5">
        <div class="col-lg-8 text-center">
          <h2 class="fw-bold mb-3">Contáctanos</h2>
          <p class="lead text-muted">Estamos disponibles para atender tus emergencias y consultas.</p>
        </div>
      </div>
      
      <div class="row g-4">
        
        <div class="col-lg-6">
          <div class="bg-white p-4 rounded shadow-sm h-100">
            <h4 class="mb-4">Información de contacto</h4>
            <div class="d-flex mb-4">
              <div class="bg-primary rounded-circle p-3 me-3 text-white">
                <i class="fas fa-map-marker-alt"></i>
              </div>
              <div>
                <h5 class="mb-1">Dirección</h5>
                <p class="mb-0">Av Fraternidad S/N, Barrio de San Marcos Yachihualcaltepec, Toluca, México</p>
              </div>
            </div>
            
            <div class="d-flex mb-4">
              <div class="bg-primary rounded-circle p-3 me-3 text-white">
                <i class="fas fa-phone-alt"></i>
              </div>
              <div>
                <h5 class="mb-1">Teléfono</h5>
                <p class="mb-1">722-124-3028</p>
              </div>
            </div>
            
            <div class="d-flex mb-4">
              <div class="bg-primary rounded-circle p-3 me-3 text-white">
                <i class="fas fa-envelope"></i>
              </div>
              <div>
                <h5 class="mb-1">Correo electrónico</h5>
                <p class="mb-0">cerrajeriacardoso1@gmail.com</p>
              </div>
            </div>
            
            <div class="d-flex">
              <div class="bg-primary rounded-circle p-3 me-3 text-white">
                <i class="fas fa-clock"></i>
              </div>
              <div>
                <h5 class="mb-1">Horario de atención</h5>
                <p class="mb-1">Lunes a Viernes 9am - 6pm</p>
                <p class="mb-0">Sabado: 9 am - 3 pm </p>
              </div>
            </div>
            
            <hr class="my-4">
            
            <h5 class="mb-3">Síguenos en redes</h5>
            <div class="d-flex gap-3">
              <a href="#" class="btn btn-outline-primary rounded-circle p-2">
                <i class="fab fa-facebook-f"></i>
              </a>
              <a href="#" class="btn btn-outline-primary rounded-circle p-2">
                <i class="fab fa-instagram"></i>
              </a>
              <a href="#" class="btn btn-outline-primary rounded-circle p-2">
                <i class="fab fa-twitter"></i>
              </a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Mapa -->
  <section class="bg-light py-0">
    <div class="container-fluid px-0">
      <div class="map-container">
        <iframe src="https://www.google.com/maps/embed?pb=!4v1749003601768!6m8!1m7!1sk4zYXHsKszVKuAbCr1h9Og!2m2!1d19.32557371971701!2d-99.66909462161252!3f245.3449706477803!4f-38.928484504304734!5f0.7820865974627469" width="100%" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
      </div>
    </div>
</section>

  <!-- Footer -->
  <footer class="bg-dark text-white py-5">
    <div class="container">
      <div class="row g-4">
        <div class="col-lg-4">
          <h4 class="mb-4">Cerrajería Cardoso</h4>
          <p>Servicio profesional de cerrajería disponible en Toluca.</p>
          <div class="d-flex gap-3 mt-4">
            <a href="#" class="text-white"><i class="fab fa-facebook-f"></i></a>
            <a href="#" class="text-white"><i class="fab fa-twitter"></i></a>
            <a href="#" class="text-white"><i class="fab fa-instagram"></i></a>
          </div>
        </div>
        
        <div class="col-lg-4 col-md-4">
          <h5 class="mb-4">Contacto</h5>
          <ul class="list-unstyled">
            <li class="mb-3 d-flex">
              <i class="fas fa-map-marker-alt me-3 mt-1"></i>
              <span>Av Fraternidad S/N, Barrio de San Marcos Yachihualcaltepec, Toluca, México</span>
            </li>
            <li class="mb-3 d-flex">
              <i class="fas fa-phone-alt me-3 mt-1"></i>
              <span>722-56-38-606</span>
            </li>
            <li class="mb-3 d-flex">
              <i class="fas fa-envelope me-3 mt-1"></i>
              <span>cerrajeriacardoso1@gmail.com</span>
            </li>
          </ul>
        </div>
      </div>
      
      <hr class="my-4">
      
      <div class="row">
        <div class="col-md-6 text-center text-md-start">
          <p class="mb-0">&copy; 2025 Cerrajería Cardoso. Todos los derechos reservados.</p>
        </div>
      </div>
    </div>
  </footer>

  <!-- Bootstrap JS -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
  <!-- Script personalizado -->
  <script src="script.js"></script>
</body>
</html>
