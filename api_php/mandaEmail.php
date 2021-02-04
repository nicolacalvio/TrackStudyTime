<?php
$to = $_GET['email'];
$subject = "Pausa scaduta";
$pausa = $_GET['pausa'];
$message = 'Caro/a '.$_GET['nome'].',<br>';
$message .= "questa email è per avvisarti che la tua pausa di ".$pausa." minuti è scaduta, ti preghiamo di tornare subito a studiare<br><br>";
$message .= "Saluti<br>";
$message .= "Nicola Calvio Technology<br>";

// Always set content-type when sending HTML email
$headers = "MIME-Version: 1.0" . "\r\n";
$headers .= "Content-type:text/html;charset=UTF-8" . "\r\n";

// More headers
$headers .= 'From: <noreply@nicolacalvio.com>' . "\r\n";

mail($to,$subject,$message,$headers);
echo "mandato";