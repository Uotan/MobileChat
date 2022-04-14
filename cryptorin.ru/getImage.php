<?php


$filebase64 = $_POST['filebase64'];

$bin = base64_decode($filebase64);


$im = imageCreateFromString($bin);


if (!$im) {
  die('Base64 value is not a valid image');
}


$img_file = '../images//filename.jpg';


//imagepng($im, $img_file, 0);


$success = file_put_contents($img_file, $bin);


exec('convert ../files//filename.jpg -resize 1024x1024 ../files//filename.jpg');

?>