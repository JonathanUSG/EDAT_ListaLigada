Tema 5: Interpolación
Este tema aborda técnicas numéricas para estimar valores intermedios de una función a partir de datos discretos. La interpolación busca construir una función que pase exactamente por los puntos dados, mientras que los métodos de análisis de datos permiten modelar tendencias y relaciones entre variables.

Contenido

📁 Metodos_Interpolacion/: Métodos que construyen funciones para estimar valores entre puntos conocidos.

Interpolación Lineal
Interpolación Polinómica


📁 Analisis_Datos/: Métodos para modelar relaciones y tendencias en datos.

Correlación
Regresión
Mínimos Cuadrados




Definiciones de los Métodos

Interpolación Lineal: Estima valores entre dos puntos conocidos conectándolos con una línea recta. Es simple y útil para datos con comportamiento aproximadamente lineal.
Interpolación Polinómica: Construye un polinomio de grado $n$ que pasa por $n+1$ puntos. Es más precisa para datos complejos, pero puede sufrir oscilaciones (fenómeno de Runge).
Correlación: Mide la fuerza y dirección de la relación entre dos variables, usando coeficientes como el de Pearson.
Regresión: Modela la relación entre variables dependientes e independientes, ajustando una función (lineal o no lineal) a los datos.
Mínimos Cuadrados: Ajusta una función minimizando la suma de los cuadrados de los errores entre los datos y el modelo.


Comparación General



Característica
Métodos de Interpolación
Métodos de Análisis de Datos



Objetivo
Estimar valores exactos
Modelar tendencias


Puntos de datos
Pasa exactamente por puntos
Ajusta una curva aproximada


Complejidad
Moderada
Variable (depende del modelo)


Ejemplos
Lineal, Polinómica
Correlación, Regresión, Mínimos Cuadrados



Objetivo del Tema
El objetivo de este tema es que el estudiante:

Comprenda cómo funcionan los métodos de interpolación y análisis de datos.
Aplique cada método según el tipo de datos y el objetivo del análisis.
Evalúe las ventajas y limitaciones de cada técnica.
Analice la precisión y estabilidad de los métodos.


Recomendaciones

Visualizar los datos antes de elegir un método.
Verificar la cantidad y calidad de los puntos de datos.
Considerar el fenómeno de Runge al usar interpolación polinómica de alto grado.
Comparar los resultados de diferentes métodos para validar modelos.


Notación

$x_i, y_i$: Puntos de datos conocidos.
$f(x)$: Función interpolada o modelo ajustado.
$n$: Número de puntos o grado del polinomio.
$r$: Coeficiente de correlación.
$e_i$: Error en el ajuste (diferencia entre dato y modelo).

