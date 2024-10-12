DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

-- Tabla de roles
CREATE TABLE roles (
    id_rol INT PRIMARY KEY,
    nombre_rol VARCHAR(30)
);

-- Insertamos roles (puedes agregar más si necesitas)
INSERT INTO roles (id_rol, nombre_rol) VALUES
(1, 'Administrador'),
(2, 'Entrenador'),
(3, 'Socio');

-- Tabla de usuarios
CREATE TABLE usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre_usuario VARCHAR(50),
    contraseña_usuario VARCHAR(255),
    id_rol INT,
    activo BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

-- Insertamos un usuario inicial
INSERT INTO usuarios (nombre_usuario, contraseña_usuario, id_rol) VALUES
('admin_club', 'clave123', 1);
