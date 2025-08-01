
# ASP.NET Core 9 + OpenIddict 7 + PKCE + MultiCliente

Este repositorio contiene un ejemplo completo de autenticación y autorización utilizando **ASP.NET Core 9** con **OpenIddict 7** y soporte para múltiples clientes (PKCE). Se incluyen dos aplicaciones cliente SPA construidas con Angular.

## 📁 Estructura del proyecto

```
aspnetcore9-openiddict-pkce-multiclient/
│
├── OpenIddictWebServer/         --> Servidor de identidad (ASP.NET Core 9 MVC + OpenIddict)
├── angular-oauth-spa/           --> Cliente Angular con flujo OAuth PKCE
└── angular-oidc-spa/            --> Cliente Angular con flujo OpenID Connect PKCE
```

---

## 🔐 OpenIddictWebServer

Servidor de autenticación construido con ASP.NET Core 9 (MVC) y OpenIddict, configurado para permitir múltiples formas de inicio de sesión:

### Métodos de inicio de sesión soportados:

1. ✅ **Inicio de sesión directo** con usuario y contraseña
2. 🌐 **Login con terceros**: Facebook y Google
3. 🔒 **Autenticación en dos pasos (2FA)** con OTP por email o aplicación
4. 🔁 **Redirección desde clientes**:
   - Si el usuario no está autenticado en el cliente Angular, es redirigido al servidor para autenticarse.
   - Luego, es redirigido de vuelta al cliente con el token correspondiente.

---

## 🚀 Cómo ejecutar el proyecto

### 🔧 Requisitos previos

- [.NET 9 SDK (Preview o Daily Build)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Node.js y Angular CLI
- Cuenta de desarrollador de Google y Facebook (para las credenciales OAuth)

---

### ▶️ Pasos para ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/aspnetcore9-openiddict-pkce-multiclient.git
   cd aspnetcore9-openiddict-pkce-multiclient
   ```

2. Ejecuta el servidor:
   ```bash
   cd OpenIddictWebServer
   dotnet restore
   dotnet run
   ```

3. Ejecuta uno de los clientes Angular:
   ```bash
   cd ../angular-oauth-spa
   npm install
   ng serve
   ```

4. Abre el navegador en:
   - `http://localhost:4200` para el cliente OAuth
   - `http://localhost:4300` si ejecutas el cliente OIDC (puedes cambiar el puerto)

---

## 🧠 Tecnologías utilizadas

- **ASP.NET Core 9**
- **OpenIddict 7.0**
- **OAuth / OpenID Connect**
- **PKCE (Proof Key for Code Exchange)**
- **Angular 19 SPA**
- **2FA**
- **Inicio de sesión externo (Google/Facebook)**

---

## 📚 Créditos y agradecimientos

Este proyecto fue desarrollado para mostrar un sistema de autenticación centralizado usando OpenIddict con múltiples clientes SPA como ejemplo práctico de arquitectura moderna de identidad.

---

## 📝 Licencia

MIT © 2025 - Puedes usar este proyecto libremente para fines educativos o comerciales.
