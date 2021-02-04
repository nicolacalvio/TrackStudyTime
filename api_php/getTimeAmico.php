<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$data = date("Y/m/d");
$nome = $_GET['nome'];
$sql = $mysqli->prepare("select DISTINCT tempo_studio, utente from tempi where dataInserimento=? and utente in (select  id_amico from amici where id_utente=?) ORDER BY tempo_studio DESC");
$sql ->bind_param("ss", $data, $nome);
$sql->execute();
$result = $sql->get_result();
if ($result) {
    while($row = $result->fetch_array(MYSQLI_NUM)) {
        echo "tempo studio: ".gmdate("H:i:s",$row[0] )."    utente: ".$row[1]."-";
    }

}
$mysqli->close();