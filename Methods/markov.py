# coding=utf-8

import numpy as np

def stringToMatrix(input_str = ''):
    """Convierte un string en una matrix de numeros reales. El string debe tener el formato:\n
    n1, n2; m1, m2\n
    Donde ; separa cada fila de la matrix, resultando una matrix:  \n
    [[n1, n2], [m1, m2]]
    """
    _matrix = []
    items = input_str.split(';')
    for item in items:
        _matrix.append(map(float, item.split(',')))
    return _matrix


def nextSteps(matrix, steps=1):
    """Calcula una determinada cantidad de pasos siguientes en un matrix.
    Parámetros:
    matrix -- Matrix inicial
    steps -- Pasos siguientes a futuro
    """
    P = np.matrix(matrix)
    return P**steps


# --------------------------------------------------------
matrix1 = [[0.08, 0.184, 0.368,	0.368],
           [0.632, 0.368, 0, 0],
           [0.264, 0.368, 0.368, 0],
           [0.08, 0.184, 0.368, 0.368]]

print(nextSteps(matrix1, 6))

print(stringToMatrix(input_str = '1, 3, 2; 3, 5, 7'))