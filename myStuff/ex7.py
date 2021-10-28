# variables to convert inches and pounds to centimeters and kilo 

x_in_inch = 137
y_in_pound = 256

y_in_kilo = round(y_in_pound * 0.453592) # round() is used to  round off the values
x_in_centimeters = x_in_inch * 2.54

print "Let's convert %d in inches to centimeters." % x_in_inch
print "Let's convert %d in pounds to kilos." % y_in_pound
print "value of %d inches in centimeters is %f." % (x_in_inch, x_in_centimeters)
print "value of %d pounds in kilo is %f." % (y_in_pound, y_in_kilo)