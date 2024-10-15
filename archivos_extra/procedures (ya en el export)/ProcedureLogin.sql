DELIMITER //

CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usuario` VARCHAR(20), IN `Clave` VARCHAR(15)) 
BEGIN
    SELECT nombre_usuario
    FROM usuarios
    WHERE nombre_usuario = Usuario
    AND clave_usuario = Clave;
END//

DELIMITER ;
