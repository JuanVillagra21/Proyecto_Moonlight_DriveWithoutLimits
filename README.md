# 🚗 Drive Without Limits

> Videojuego de conducción contrarreloj desarrollado en Unity, enfocado en el diseño multiplataforma y la adaptación de esquemas de entrada (Android ➔ PC).

---

## 🎮 Sobre el Proyecto

**Drive Without Limits** es un juego de conducción contrarreloj en el que el jugador debe esquivar el tráfico vehicular y alcanzar la meta antes de que el cronómetro llegue a cero.

El proyecto fue concebido originalmente para dispositivos móviles **Android**, aprovechando el **acelerómetro** como método de control. Posteriormente, se llevó a cabo un proceso de portabilidad y adaptación para **PC (Windows)**, modificando el sistema de control, la interfaz, la resolución, los límites de pista y añadiendo un menú de pausa y pantallas de estado.

---

## ✨ Características Principales

* **Conducción:** Control del vehículo adaptado a dos sistemas de entrada diferentes: acelerómetro en Android y teclado en PC.
* **Obstáculos y Tráfico:** Detección de colisiones contra otros vehículos en la pista.
* **Sistema de Tiempo Límite:** Condición de victoria por llegada a la meta y derrota por tiempo agotado.
* **Control de Flujo:** Menú principal, sistema de pausa en PC y pantallas de fin de juego (Victoria/Derrota).
* **Adaptación Multiplataforma:** Ajustes de interfaz y resolución para la versión de PC, configurada a 1920 × 1080.

---

## 🔄 Comparativa Multiplataforma

| Característica | 📱 Android | 🖥️ PC (Windows) |
| :--- | :--- | :--- |
| **Control principal** | Acelerómetro (inclinación) | Teclado (W, A, S, D) |
| **Menú de Pausa** | — | Tecla `ESC` |
| **Resolución** | Adaptada a dispositivo móvil | 1920 × 1080 |
| **Distribución** | Paquete APK | Ejecutable (`.exe`) |

---

## 🕹️ Controles

### 📱 Android

* **Giro / Dirección:** Inclinar el dispositivo hacia la izquierda o hacia la derecha para orientar el vehículo.

### 🖥️ PC

| Tecla | Acción |
| :---: | :--- |
| **W** | Acelerar / Avanzar |
| **A** | Girar hacia la izquierda |
| **S** | Frenar / Retroceder |
| **D** | Girar hacia la derecha |
| **ESC** | Pausar / Reanudar partida |

---

## 🌿 Gestión del Repositorio (Ramas)

Para mantener la trazabilidad del proceso de portabilidad, el repositorio se estructuró en dos ramas principales:

* `main`: Código y configuración del proyecto base orientado a **Android**.
* `adaptacionPC`: Adaptación del proyecto para **PC**, incluyendo los controles mediante teclado, menú de pausa, resolución 1920 × 1080 y pantallas de victoria/derrota.

---

## 🛠️ Tecnologías

* **Motor de desarrollo:** Unity 2023.2.22f1.
* **Lenguaje de programación:** C#.
* **Control de versiones:** Git & GitHub.
* **Plataformas de destino:** Android | Windows (PC).

---

## 📦 Requisitos del Sistema

### 📱 Android

* **Sistema operativo:** Android 8.0 o superior.
* **Hardware:** Dispositivo móvil con sensor de acelerómetro integrado.

### 🖥️ PC

* **Sistema operativo:** Windows 10 o superior (64 bits).
* **Procesador:** CPU de 64 bits.
* **Memoria RAM:** 4 GB.
* **Periféricos:** Teclado.
* **Resolución recomendada:** 1920 × 1080.

---

## 📚 Documentación

El proyecto incluye documentación técnica sobre el desarrollo y la adaptación multiplataforma:

* 📄 [Documentación — Drive Without Limits](Documentacion_Drive_Without_Limits.pdf)

---

## ▶️ Instrucciones de Ejecución

### 📱 Android

1. Descargar el archivo `.apk` en el dispositivo móvil.
2. Instalar la aplicación.
3. Abrir el juego y controlar el vehículo inclinando el dispositivo.

### 🖥️ PC

1. Descargar y descomprimir la compilación para PC.
2. Ejecutar el archivo `Drive Without Limits.exe`.
3. Utilizar las teclas **WASD** para conducir y **ESC** para pausar.

---

## 👨‍💻 Autor

**Juan Ignacio Villagra** — Desarrollador del proyecto.

Proyecto desarrollado de manera individual.
