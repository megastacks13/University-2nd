# -*- coding: utf-8 -*-
"""
Created on Thu Feb  8 18:11:47 2024

@author: Jaime Alonso
"""

import numpy as np
import matplotlib.pyplot as plt
import numpy.polynomial.polynomial as pol

# Horner (Exercise 1)
def horner(x0, p):
    try:
        q = np.zeros(len(p))
        q[-1] = p[-1]
    except:
        return 0,0
    
    for i in range(len(q)-2, -1, -1):
        q[i] = p[i] + q[i+1]*x0
     
    return q[1:], q[0]

#Horner with vectors (Exercise 2)
def hornerV(x, p):
    y = np.zeros(len(x))
    k = p
    
    for i in range(len(x)):
        q, y[i] = horner(x[i], k)
    
    return y

#polDer (Exercise 3)
def polDer(x0, p):
    r = zeros_like(p)
    j = zeros_like(p)
    k = np.copy(p)
    
    for i in range (len(p)):
        k, r[i] = horner(x0, k)
        j[i] = k/(x0-r[i])
    
        
    
    
    

#Exercise 1
def main1():
    
    p0 = np.array([1.,2,1])
    x0 = 1.
    q, r = horner(x0,p0)
    rp   = pol.polyval(x0,p0) 

    print('\nQ coefficients = ', q)
    print('P0(1)        = ', r)
    print('With polyval = ', rp)
    
    p1 = np.array([1., -1, 2, -3,  5, -2])
    x1 = 1.
    q1, r1 = horner(x1,p1)
    rp1   = pol.polyval(x1,p1) 

    print('\nQ coefficients = ', q1)
    print('P1(1)        = ', r1)
    print('With polyval = ', rp1)
    
    p2 = np.array([1., -1, -1, 1, -1, 0, -1, 1])
    x2 = -1.
    q2, r2 = horner(x2,p2)
    rp2   = pol.polyval(x2,p2) 

    print('\nQ coefficients = ', q2)
    print('P0(-1)        = ', r2)
    print('With polyval = ', rp2)

#Exercise 2
def main2():
    x = np.linspace(-1, 1)
    p = np.array([1., -1, 2, -3, 5, -2])
    r = np.array([1., -1, -1, 1, -1, 0, -1, 1])
    
    plt.figure()
    plt.plot(x, hornerV(x, p))
    plt.plot(x, pol.polyval(x,p))
    plt.title('P')
    plt.show()
    
    plt.figure()
    plt.plot(x, hornerV(x, r))
    plt.plot(x, pol.polyval(x,r))
    plt.title('R')
    plt.show()


if __name__ == "__main__":
    main2()