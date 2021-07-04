#!/bin/bash
MSYS_NO_PATHCONV=1 openssl req -x509 -newkey rsa:2048 -keyout https/localhost.key -out https/localhost.crt -days 365 -subj "/CN=wallet.local/O=wallet.local/C=US" -config ssl-selfsigned.cnf -passout pass:MyCertificatePassword
winpty openssl pkcs12 -export -out https/localhost.pfx -inkey https/localhost.key -in https/localhost.crt -name "Localhost selfsigned certificate" -password pass:MyCertificatePassword -passin pass:MyCertificatePassword
winpty openssl rsa -in https/localhost.key -out https/localhost.key -passin pass:MyCertificatePassword