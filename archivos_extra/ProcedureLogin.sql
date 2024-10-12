DELIMITER //
CREATE PROCEDURE IngresoLogin(IN Usuario VARCHAR(50), IN Pass VARCHAR(255))
BEGIN
    SELECT nombre_rol
    FROM usuarios u
    INNER JOIN roles r ON u.id_rol = r.id_rol
    WHERE u.nombre_usuario = Usuario
    AND u.contraseña_usuario = Pass
    AND u.activo = 1;
END //
DELIMITER ;
