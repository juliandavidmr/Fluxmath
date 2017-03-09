# coding=utf-8

import numpy as np


def stringToMatrix(input_str=''):
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


def prediccion(list_frases, actual):
    """Predice la siguiente posible palabra 
    """
    actual = str(actual).strip()
    count_map = {}    # Almacena todas las claves { 'palabra futura': veces }
    counter = 0       # Cantidad de elementos o palabras
    prob_map = {}       # Almacena cada una de las probabilidades
    for item in list_frases:
        frases_split = str(item).split(" ")  # Separa la oracion por espacios
        for index, word in enumerate(frases_split):
            # print("Palabra ", str(word), str(actual))

            if str(word) == str(actual):                 # Se busca la palabra actual
                counter = counter + 1                    # Aumenta contador de palabras futuras
                # Puede darse el caso de que la entrada es una palabra, se
                # inicializa entonces con la actual
                future = str(actual)
                # Hay palabra futuro? es decir, estado j
                if (index + 1) < len(frases_split):
                    # Obtiene la palabra futuro
                    future = str(frases_split[index + 1])
                if count_map.has_key(future):
                    count_map[future] = count_map[future] + 1
                else:
                    count_map[future] = 1

                for key, value in count_map.iteritems():
                    prob_map[key] = float(value) / float(counter)

    print(count_map, counter)
    return [count_map, prob_map]


# --------------------------------------------------------
"""
 matrix1 = [[0.08, 0.184, 0.368,	0.368],
					 [0.632, 0.368, 0, 0],
					 [0.264, 0.368, 0.368, 0],
					 [0.08, 0.184, 0.368, 0.368]]

 print(nextSteps(matrix1, 6))

 print(stringToMatrix(input_str = '1, 3, 2; 3, 5, 7'))
"""
