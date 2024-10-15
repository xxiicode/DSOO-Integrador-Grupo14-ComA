DELIMITER //

-- Procedimiento para verificar si existe un DNI
CREATE PROCEDURE ExisteDNI(IN dni VARCHAR(20), OUT existe INT)
BEGIN
    SELECT COUNT(*) INTO existe FROM Clientes WHERE DNI = dni;
END //

-- Procedimiento para registrar un nuevo cliente
CREATE PROCEDURE RegistrarCliente(
    IN nombre VARCHAR(50),
    IN apellido VARCHAR(50),
    IN dni VARCHAR(20),
    IN direccion VARCHAR(100),
    IN mail VARCHAR(100),
    IN telefono VARCHAR(20),
    IN fechaNacimiento DATE,
    IN tipo VARCHAR(20)
)
BEGIN
    INSERT INTO Clientes (Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo)
    VALUES (nombre, apellido, dni, direccion, mail, telefono, fechaNacimiento, tipo);
END //

DELIMITER ;
