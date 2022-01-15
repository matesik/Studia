from numpy import exp, asarray
from numpy.random import rand, seed, randn
from numpy.random.mtrand import uniform
import math


def objective(point1, point2):
    return -math.cos(point1)*math.cos(point2)*math.exp(-(point1-math.pi)**2-(point2-math.pi)**2)


def SA(objective, area, iterations, temperature):
    startPoint1 = uniform(-100, 100)
    startPoint2 = uniform(-100, 100)
    fitnessValue = objective(startPoint1, startPoint2)
    for i in range(iterations):
        temperature = temperature/100  # (i+1)
        rho = 2
        if temperature != 0:
            tmp = exp(-rho/temperature)
            difference1 = startPoint1-(startPoint1-tmp)
            difference2 = startPoint2-(startPoint2-tmp)
            if difference1 < 0 and difference2 < 0:
                startPoint1 = startPoint1-tmp
                startPoint2 = startPoint2-tmp
    return startPoint1, startPoint2


area = asarray([[10, -10]])
temperature = 12
iterations = 1200
output = SA(objective, area, iterations, temperature)
print("F(", output, ") =", objective(output[0], output[1]))
