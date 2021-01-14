﻿Module modQryCliPrin

    Public qry4dCliPri As String = "SELECT   CODIGO_CLIENTE AS ID_CLIENTE, NOMBRE_CLIENTE AS NOM_CLIENTE, IDENTIFICACION_FISCAL AS RFC, " +
         " NAME_ALT_RAZON_SOCIAL AS RAZON_SOCIAL, INACTIVO, RECORD_DATE AS FECHA_INGRESO, " +
         " DIRECCION_PRINCIPAL_1,DIRECCION_PRINCIPAL_2, Direccion_3 AS DIRECCION_PRINCIPAL_3, " +
         " NoExterior_s AS NUM_EXTERIOR, NoInterior_s AS NUM_INTERIOR, Colonia_s AS COLONIA, Municipio_s AS MUNICIPIO, " +
         " Localidad_s AS LOCALIDAD, Codigo_ciudad AS ID_CIUDAD, Codigo_estado AS ID_ESTADO, Codigo_pais AS ID_PAIS, ZONA AS ID_ZONA," +
         " CODIGO_POSTAL_PRINCIPAL AS CP, TELEFONO, TELEFONO_2, FAX, " +
         " Email_Fiscal AS EMAIL_FISCAL, E_MAIL, Codigo_Cuenta_Contable_Cliente AS ID_CUENTA, " +
         " TIPO_MONEDA AS ID_MONEDA, TERMINOS_DE_PAGO_DIAS AS DIAS_CREDITO, " +
         " TERMINOS_DE_PAGO_ALFA_NUM AS TERMINO_CREDITO, LIMITE_CREDITO, BALANCE AS SALDO, " +
         " BALANCE_RESERV1 AS RESERVA, CLIENT_TYPE AS ID_TIPO, Codigo_Giro AS ID_GIRO, Codigo_Categoria AS ID_CATEGORIA, " +
         " Codigo_sector AS ID_SECTOR, LOCALIZACION_CLIENTE AS ID_LOCALIZACION,SALESMAN AS ID_VENDEDOR,CURRENT_DATE ( ) AS FECHA_MOD " +
         " FROM  CLNT_Ficha_Principal WHERE EMPRESA = 'CIMSA'; "

    Public qry4dCliGir As String = "SELECT CODE AS ID_GIRO,DESCRIPTION_SPN AS NOM_GIRO,CURRENT_DATE ( ) AS FECHA_MOD " +
         " FROM SIST_Lista_6 WHERE CORP = 'CIMSA' AND GROUP_CATEGORY = 'GIRNE'; "

    Public qry4dCliTip As String = "SELECT CODE AS ID_TIPO_CLN,DESCRIPTION_SPN AS NOM_TIPO_CLN, CURRENT_DATE ( ) AS FECHA_MOD " +
        " FROM SIST_Lista_1 WHERE GROUP_CATEGORY ='CLITP'; "

    Public qry4dCliCiu As String = "SELECT CODE3_STRNG_25 AS ID_CIUDAD, DESCRIPTION_SPN AS NOM_CIUDAD,CURRENT_DATE ( ) AS FECHA_MOD " +
        " FROM SIST_Lista_5 WHERE CORP = 'CIMSA' AND GROUP_CATEGORY = 'CIUDA'; "

    Public qry4dCliEdo As String = "SELECT CODE2_STRNG_10 AS ID_ESTADO ,DESCRIPTION_SPN AS NOM_ESTADO, CURRENT_DATE ( ) AS FECHA_MOD " +
" FROM SIST_Lista_5 WHERE CORP = 'CIMSA' AND GROUP_CATEGORY = 'ESTAD'; "

    Public qry4dCliZon As String = "SELECT   CODE AS ID_ZONA, DESCRIPTION_SPN AS NOM_ZONA,CURRENT_DATE ( ) AS FECHA_MOD " +
" FROM     SIST_Lista_1 WHERE    CORP = 'CIMSA' AND      GROUP_CATEGORY = 'CZONE'; "

    Public qrySqlCliPri As String = "SELECT * FROM CLIENTES"
    Public qrySqlCliGir As String = "SELECT * FROM CLIENTES_GIROS"
    Public qrySqlCliTio As String = "SELECT * FROM CLIENTES_TIPOS"
    Public qrySqlCliCiu As String = "SELECT * FROM CIUDADES"
    Public qrySqlCliEdo As String = "SELECT * FROM ESTADOS"
    Public qrySqlCliZon As String = "SELECT * FROM ZONAS"

    Public delSqlCliPri As String = "DELETE FROM CLIENTES"
    Public delSqlCliGir As String = "DELETE FROM CLIENTES_GIROS"
    Public delSqlCliTip As String = "DELETE FROM CLIENTES_TIPOS"
    Public delSqlCliCiu As String = "DELETE FROM CIUDADES"
    Public delSqlCliEdo As String = "DELETE FROM ESTADOS"
    Public delSqlCliZon As String = "DELETE FROM ZONAS"

    Public intSqlCliPri As String = "INSERT INTO CLIENTES VALUES (@ID_CLIENTE, @NOM_CLIENTE,	@RFC, @RAZON_SOCIAL, @INACTIVO,	@FECHA_INGRESO,	@DIRECCION_PRINCIPAL_1,	@DIRECCION_PRINCIPAL_2, " +
    " @DIRECCION_PRINCIPAL_3, @NUM_EXTERIOR, @NUM_INTERIOR, @COLONIA, @MUNICIPIO, @LOCALIDAD, @ID_CIUDAD, @ID_ESTADO, @ID_PAIS, " +
    " @ID_ZONA,	@CP, @TELEFONO, @TELEFONO_2, @FAX, @EMAIL_FISCAL, @E_MAIL, @ID_CUENTA, @ID_MONEDA, @DIAS_CREDITO, " +
    " @TERMINO_CREDITO,	@LIMITE_CREDITO, @SALDO, @RESERVA, @ID_TIPO, @ID_GIRO, @ID_CATEGORIA, @ID_SECTOR, @ID_LOCALIZACION, " +
    " @ID_VENDEDOR,	@FECHA_MOD)"
    Public intSqlCliGir As String = "INSERT INTO CLIENTES_GIROS VALUES(@ID_GIRO, @NOM_GIRO,@FECHA_MOD)"
    Public intSqlCliTip As String = "INSERT INTO CLIENTES_TIPOS VALUES (@ID_TIPO_CLN,@NOM_TIPO_CLN,@FECHA_MOD)"
    Public intSqlCliCiu As String = "INSERT INTO CIUDADES VALUES (@ID_CIUDAD,@NOM_CIUDAD,@FECHA_MOD)"
    Public intSqlCliEdo As String = "INSERT INTO ESTADOS VALUES(@ID_ESTADO, @NOM_ESTADO, @FECHA_MOD)"
    Public intSqlCliZon As String = "INSERT INTO ZONAS VALUES(@ID_ZONA, @NOM_ZONA, @FECHA_MOD)"


End Module
