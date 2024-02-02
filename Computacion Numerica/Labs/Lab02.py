# -*- coding: utf-8 -*-
"""
Created on Thu Feb  1 18:08:13 2024

@author: Jaime Alonso
"""
import numpy as np
import time


f = lambda x: np.exp(x)

x = np.linspace(-1, 1, 300000)

#%% y will grow inside the loop (slowest method)
y = np.array([])
t = time.time()

for i in range(len(x)):
    y = np.append(y, f(x[i]))

t1 = time.time() -t

#%% reserve space and fill inside the loop (mid method)

y = np.zeros_like(x)
t = time.time()

for i in range(len(x)):
    y[i] = f(x[i])

t2 = time.time() -t
#%% vectorization (the fastest)
t = time.time()
y = f(x)
t3 = time.time() - t

#%% Plot
import numpy as np
import matplotlib.pyplot as plt

f = lambda x: np.exp(x) * np.sin(15*x)
# For not given any value, linspace will use 50 point. For curved functions
# is better to use more points.
# Non continous functions will be plotted as continous, ej 1/x
x = np.linspace(-1, 1, 200)
y = f(x)
# if not 'o' added, it will use a continous line. 'o-' is used for plotting 
# points AND the continous line
plt.figure() #a figure is created and  all graphs will be plotted in it
plt.plot(x, y, label = 'function')
plt.plot(x, 0*x, 'k', label = 'Axis')# Adding a plot for the X axis
plt.title("plot") #Title to the figure
plt.legend() # Shows the legend
plt.savefig("plot.png") # saves the plot as an image
plt.show()

#%% Factorials -> Taylors (de Morgans) Series
# The np.math.Factorial receives an int32 and returns a int32. May overflow
# To obtain the factorial of a float we should do the following:

def fact(n):
    total = 1.
    for i in range(1, n+1):
        total *= i
    return total

#%% Taylor algorithm (1st version)
import numpy as np

f = lambda x: np.exp(x)

x0 = 0.5
polynomial = 0.
factorial = 1. 

for i in range(4):
    term = x0**i / factorial
    polynomial += term
    
    factorial *= i+1

print('Exact value = ',  f(x0))
print('Approx value = ', polynomial)
    
#%% Taylor algorithm (2nd version)
import numpy as np


def P(x0, degree):
    polynomial = 0.
    factorial = 1. 
    
    for i in range(degree + 1):
        term = x0**i / factorial
        polynomial += term
        
        factorial *= i+1
    return polynomial
    
f = lambda x: np.exp(x)

x0 = 0.5

print('Exact value = ',  f(x0))
print('Approx value = ', P(x0, 10))

#%% Taylor algorithm (3rd, 4th version)
import numpy as np
import matplotlib.pyplot as plt

def P(x, degree):
    polynomial = 0.
    factorial = 1. 
    
    for i in range(degree + 1):
        term = x**i / factorial
        polynomial += term
        
        factorial *= i+1
    return polynomial
    
f = lambda x: np.exp(x)

x0 = np.linspace(-1, 1)

plt.figure()
plt.plot(x, f(x), label='f')
plt.plot(x, P(x, 2), label='P2')
plt.plot(x, 0*x, 'k')
plt.legend()
plt.show()
#%% Taylor algorithm (5th version)
import numpy as np
import matplotlib.pyplot as plt

def P(x, degree):
    polynomial = 0.
    factorial = 1. 
    
    for i in range(degree + 1):
        term = x**i / factorial
        polynomial += term
        
        factorial *= i+1
    return polynomial
    
f = lambda x: np.exp(x)

x = np.linspace(-3, 3)

plt.figure()
plt.plot(x, f(x), label='f')
plt.plot(x, 0*x, 'k')
for degree in range(2, 6):
    plt.plot(x, P(x, degree), label='P' + str(degree))
    plt.legend()
    plt.pause(1)
plt.show()


#%% Exercice 1
import numpy as np
import matplotlib.pyplot as plt

f = lambda x : np.exp(x)
x0 = -0.4
tol = 1*(10**(-8))
maxSumNum = 100


def P(x):
    total = 0 
    factorial = 1
    numberOfIterations = 0
    term = 1
    
    while numberOfIterations < maxSumNum and np.abs(term) > tol:
        term = x**numberOfIterations/factorial
        total += term
        factorial *= numberOfIterations+1
        numberOfIterations +=1
    return total,numberOfIterations

print('Function value in ', x0, '\t\t= ', f(x0))
print('Approximation of value in', x0, '\t= ', P(x0)[0])
print('Number of iterations\t\t\t= ', P(x0)[1])


#%% Exercise 2
import numpy as np
import matplotlib.pyplot as plt

f = lambda x : np.exp(x)
x = np.linspace(-1,1)
tol = 1*(10**(-8))
maxSumNum = 100


def P(x, tol, maxSumNum):
    
    total = 0 
    factorial = 1
    numberOfIterations = 0
    term = 1
    while numberOfIterations < maxSumNum and np.max( np.abs(term)) > tol:
        term = x**numberOfIterations/factorial
        total += term
        factorial *= numberOfIterations+1
        numberOfIterations +=1
    return total,numberOfIterations

value = P(x, tol, maxSumNum)
plt.plot(x, f(x), 'y', linewidth=5)
plt.plot(x, value[0], 'b--')

#%% Exercise 3
import numpy as np
import matplotlib.pyplot as plt

tol = 1 * (10**-8)
x0 = np.pi/4

f = lambda x : np.sin(x)
maxSumNum = 100
def P(x):
    factorial, term, sign, i = 1, 1, 1, 1
    numberOfIterations, total = 0, 0

    while numberOfIterations < maxSumNum and np.abs(term) > tol:
        term = x**(i)/factorial
        total += term *sign
        sign *= -1
        factorial *= (i+1) * (i+2)
        i +=2
        numberOfIterations +=1
    return total,numberOfIterations

print('Function value', '\t\t= ', f(x0))
print('Approximation of value', '\t= ', P(x0)[0])
print('Number of iterations\t\t\t= ', P(x0)[1])

#%% Exercise 4
import numpy as np
import matplotlib.pyplot as plt

tol = 1 * (10**-8)
x = np.linspace(-np.pi, np.pi)

f = lambda x : np.sin(x)
maxSumNum = 50
def P(x, tol, maxSumNum):
    factorial, term, sign, i = 1, 1, 1, 1
    numberOfIterations, total = 0, 0

    while numberOfIterations < maxSumNum and np.max(np.abs(term)) > tol:
        term = x**(i)/factorial *sign
        total = total + term
        sign *= -1
        factorial *= (i+1) * (i+2)
        i +=2
        numberOfIterations +=1
    return total, numberOfIterations

plt.figure()
plt.plot(x, f(x),'y', label = 'f')
plt.plot(x, P(x, tol, maxSumNum)[0], '--', label = 'P')
plt.plot(x, 0*x,'b', label = 'Axis')
plt.legend()
plt.show()

#%% Exercise 5








