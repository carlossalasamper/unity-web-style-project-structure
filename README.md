# unity-web-style-project-structure

# Estructura de un juego en Unity al estilo Frontend Web 👨‍🍳 - Desarrollo de videojuegos #3
Una forma sencilla de crear un juego en Unity con una estructura similar a la que utilizamos en el desarrollo frontend web con los frameworks de actualidad: Vue.js, Angular y React.

## 1 - Estructura de carpetas
Tenemos que recordar que por cuestiones de convención de nombres en C# y en Unity como framework **los nombres de todas las carpetas tienen que comenzar por mayúscula** preferiblemente.

Vamos a explicar cada una de las carpetas de la estructura de directorios del proyecto:

### 1.1 - /Resources
Utilizaremos la carpeta /Resources para guardar, como su nombre indica, todos los recursos de nuestro juego. Podemos crear una subcarpeta por cada tipo de recurso para mayor organización. Dentro de esta carpeta podríamos tener, por ejemplo, estas subcarpetas: Materials, Images, Fonts, I18n, etc...

### 1.2 - /Source
En esta carpeta /Source es donde irá todo el código que escribamos para el juego. **Actua como la carpeta /src que utilizamos en desarrollo web** muchas veces, pero por cuestiones de convención en C# es más correcto nombrarla así.

#### 1.2.1 - /Source/Components
En esta carpeta podemos guardar los componentes UI y de elementos del juego que vayamos desarrollando. Recuerda que el namespace de cada script vendrá dado por el alias elegido para el proyecto más la ruta hasta el script desde la carpeta /Source. Por ejemplo, para un supuesto script /Source/Components/UI/SuperButton.cs tendríamos el namespace: **WebStyleDemo.Components.UI**

#### 1.2.2 - /Source/Models
Dentro de la carpeta /Source/Models guardaremos todas las clases serializables e interfaces que vayamos a utilizar en nuestro juego.

Preparar los modelos de los datos nos ayudará a tener una visión más clara del sistema antes de comenzar a implementar los componentes. A su vez, las interfaces son una forma de abstraer las dependencias que favorece la preparación de tests o la implementación de patrones que requieren de un código desacoplado como es por ejemplo la inyección de dependencias que podemos utilizar en Unity gracias al proyecto <a href="https://github.com/svermeulen/Extenject" target="_blank">Zenject/Extenject</a>.

#### 1.2.3 - /Source/Scenes
La carpeta /Source/Scenes contiene los scripts de cada una de las escenas de nuestro juego. Para no perder la analogía con el desarrollo web, su equivalente sería la carpeta /src/views o /src/pages de cualquier framework de desarrollo frontend web.

#### 1.2.4 - /Source/Services
Como su nombre indica, en la carpeta /Source/Services alojaremos los diferentes servicios que vamos a utilizar en nuestro juego. Herramientas o utilidades que tienen una funcionalidad concreta como: Serializar o deserializar JSON (JsonService), hacer peticiones HTTP (HttpService que sería **como el axios de javascript**) o el CRUD de las partidas de los jugadores (GameDataService).

## 2. Vídeo demo ▶️
He preparado un vídeo explicando el flujo y funcionamiento del proyecto paso a paso:

<p align="center">
  <a href="https://www.youtube.com/watch?v=fCIugMLfTqM" target="_blank">
    <img width="75%" src="https://img.youtube.com/vi/fCIugMLfTqM/0.jpg">
  </a>
</p>

**Deja un comentario** con un tema que te gustaría que tratase en un vídeo!

## 3. Sobre mí
¿Te ha resultado útil este contenido? **Sígueme en redes sociales**:

<p align="center">
  <a href="https://www.youtube.com/channel/UCC-EUKPStBfQ1nEIvSl6bAQ" target="_blank">YouTube ▶️</a>
  <a href="https://instagram.com/carlossalasamper" target="_blank">Instagram 📸</a>
  <a href="https://twitter.com/carlossala95" target="_blank">Twitter 🐦</a>
  <a href="https://facebook.com/carlossala95" target="_blank">Facebook 👍</a>
</p>

God of Programming 💚
