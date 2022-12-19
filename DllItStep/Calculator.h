#pragma once

#ifdef Calculator
#define Calculator_API __declspec(dllexport)
#else
#define Calculator_API __declspec(dllimport)
#endif

extern "C" Calculator_API  double multiply(double a, double b);
extern "C" Calculator_API  double devision(double a, double b);
extern "C" Calculator_API  double plus(double a, double b);
extern "C" Calculator_API  double minus(double a, double b);
