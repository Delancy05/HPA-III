# 🧪 Laboratorio 4: Base de Datos - CRUD

**Fecha:** 24/09/2026

---

## 📚 Contenido del Repositorio

En este laboratorio se desarrolló una aplicación de escritorio utilizando **C# y Windows Forms**, conectada a una base de datos **MySQL**.

El objetivo principal fue crear un sistema para administrar productos mediante operaciones CRUD (*Crear, Leer, Actualizar y Eliminar*), permitiendo trabajar con información textual, numérica e imágenes.

Durante el laboratorio se trabajó con:

* 🗄️ Conexión a una base de datos MySQL.
* 📦 Registro y consulta de productos.
* 🖥️ Interfaz gráfica utilizando Windows Forms.
* 📊 Visualización de datos mediante un `DataGridView`.
* 🖼️ Carga y almacenamiento de imágenes de productos.
* 🔍 Búsqueda y filtrado de registros.
* 🧩 Uso de clases y objetos para organizar el código.

---

## 🛠️ Tecnologías Utilizadas

* 💻 **Lenguaje:** C#
* 🧩 **Framework:** .NET
* 🖥️ **IDE:** Visual Studio
* 🪟 **Interfaz gráfica:** Windows Forms
* 🗄️ **Base de datos:** MySQL
* 🛠️ **Herramienta de gestión:** MySQL Workbench
* 📦 **Paquete utilizado:** MySql.Data
* 📚 **Control de versiones:** Git & GitHub

---

## 📸 Capturas de Pantalla y Problemas

### 🗄️ Problema 1: Conexión a la base de datos MySQL

En este ejercicio se estableció la conexión entre la aplicación desarrollada en C# y la base de datos MySQL.

Se creó una clase de conexión utilizando `MySqlConnection`, que permite comunicarse con la base de datos y realizar las operaciones necesarias.

La base de datos utilizada contiene una tabla llamada `productos`, con campos para almacenar el identificador, nombre, precio, cantidad e imagen del producto.

📸 **Captura de pantalla:**

<img width="1147" height="735" alt="image" src="https://github.com/user-attachments/assets/a71dd996-57f0-48b5-8317-17c77487a0c4" />

---

### 📦 Problema 2: Creación de la interfaz de productos

En este ejercicio se diseñó una interfaz gráfica en Windows Forms para ingresar y visualizar información de los productos.

Se utilizaron diferentes controles, entre ellos:

* 📝 `TextBox` para ingresar datos.
* 🖼️ `PictureBox` para mostrar imágenes.
* 📊 `DataGridView` para visualizar los registros.
* 🖱️ `Button` para ejecutar acciones.
* 🖼️ `ImageList` para asociar imágenes a los botones.

La interfaz permite organizar la información de los productos y facilita la interacción con el usuario.

📸 **Captura de pantalla:**

<img width="742" height="845" alt="image" src="https://github.com/user-attachments/assets/18aa110e-056d-4ab0-ac53-e757c904d735" />

---

### ➕ Problema 3: Registro y consulta de productos

En este ejercicio se implementaron funciones para insertar y consultar productos en la base de datos.

Se utilizó una clase `Producto` para representar la información de cada registro y una colección de objetos para manejar los productos obtenidos desde MySQL.

También se utilizó un `DataGridView` para mostrar los datos almacenados en la tabla `productos`.

📸 **Captura de pantalla:**

<img width="726" height="348" alt="image" src="https://github.com/user-attachments/assets/f2836615-7ad3-499b-9db5-227c1bbb05a3" />

---

### 🖼️ Problema 4: Manejo de imágenes

En este ejercicio se trabajó con la carga, conversión y almacenamiento de imágenes de los productos.

Se utilizó el control `OpenFileDialog` para seleccionar imágenes desde la computadora y el control `PictureBox` para mostrarlas en la interfaz.

Además, se utilizó `MemoryStream` para convertir las imágenes en arreglos de bytes (`byte[]`), permitiendo almacenarlas en la base de datos MySQL mediante un campo de tipo `LONGBLOB`.

📸 **Captura de pantalla:**

<img width="958" height="868" alt="image" src="https://github.com/user-attachments/assets/6f084b8c-6b14-4012-8849-118213440f73" />

<img width="736" height="356" alt="image" src="https://github.com/user-attachments/assets/6d8f633f-e06c-4437-8ec7-e601b20a87f0" />

---

### 🔍 Problema 5: Búsqueda y filtrado de productos

En este ejercicio se implementó una función de búsqueda para facilitar la localización de productos registrados.

La aplicación permite filtrar la información mediante un campo de búsqueda y actualizar los datos mostrados en el `DataGridView`.

Para realizar esta función se utilizaron consultas SQL con parámetros y el evento `TextChanged` del campo de búsqueda.

📸 **Captura de pantalla:**

<img width="736" height="505" alt="image" src="https://github.com/user-attachments/assets/80bad846-2b53-44b2-adc6-c6861d4d91ce" />

---

### ✏️ Problema 6: Operaciones CRUD

En este ejercicio se trabajó con las operaciones básicas de un sistema CRUD:

* ➕ **Crear:** Insertar nuevos productos en la base de datos.
* 👀 **Leer:** Consultar y mostrar los productos registrados.
* ✏️ **Actualizar:** Modificar la información de los productos.
* 🧹 **Limpiar:** Limpia los campos de los textbox
* 🗑️ **Eliminar:** Eliminar registros de productos.

Estas operaciones permiten administrar la información almacenada en MySQL desde la aplicación de Windows Forms.

📸 **Captura de pantalla:**

<img width="720" height="61" alt="image" src="https://github.com/user-attachments/assets/f45b596d-05a3-479a-a041-542c1c62b639" />

---

## 📁 Estructura de Carpetas o Directorios

```text
Lab 4/
│
├── Lab 4.slnx
├── Lab 4.csproj
│
├── Conexion.cs
├── Producto.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
│
├── Properties/
│   └── ...
│
└── README.md
```
---

## 👩‍💻 Autor y Contexto

* **Nombre:** Chelsy Ríos
* **Institución:** Universidad Tecnológica de Panamá (UTP)
* **Facultad:** Ingeniería en Sistemas
* **Carrera:** Ingeniería en Sistemas y Computación
* **Asignatura:** Herramientas de Programación Aplicada III
* **Grupo:** 1IL133
* **Fecha de Realización:** 24/09/2026
