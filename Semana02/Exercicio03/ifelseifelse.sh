#!/bin/bash

if [ ${1,,} = nathan ]; then
	echo "Bem vindo patrao"
elif [ ${1,,} = help ]; then
	echo "Coloque seu nome de usuario"
else
	echo "Voce nao e o patrao"
fi
