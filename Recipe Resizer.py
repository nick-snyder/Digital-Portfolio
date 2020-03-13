whole_recipe = []
ingredient_name = ""
ingredient_ounces = ""
ingredient_type = ""

def space(num = 1):
    for i in range(num):
        print ("")

def operation(multiply_or_divide, number):
    if multiply_or_divide == "multiply":
        return (float(ingredient_number * number))
        
    if multiply_or_divide == "divide":
        return (float(ingredient_number / number))

print ("Welcome to Ms Vashaw's very own recipe multiplier!")

space()

total_ingredients = int(input("How many ingredients? "))
multiply_or_divide = input("Would you like to multiply or divide your recipe? ")
number = float(input("By what? "))

if multiply_or_divide == "divide" and number == 0:
    print ("You cannot divide by zero. Please try again. ")
    number = float(input("Divide your recipe by what? "))
    
space()

for i in range(total_ingredients):
    count = i + 1
    
    if count == 1:
        order = "st"
    if count == 2:
        order = "nd"
    if count == 3:
        order = "rd"
    if count >= 4:
        order = "th"
    if count > 11 and count % 10 == 1:
        order = "st"
    if count > 12 and count % 10 == 2:
        order = "nd"
    if count > 13 and count % 10 == 3:
        order = "rd"
    if count % 100 == 0:
        order = ""
    
    ingredient_name = input("What will your " + str(count) + order + " ingredient be? ")
    ingredient_type = input("Units of measurement used for " + ingredient_name + ": ")
    ingredient_number = float(input("How many " + ingredient_type + "? "))
    
    if ingredient_type == "tsp" or "teaspoon":
        if ingredient_number * number % 3 == 0:
            ingredient_type = "tablespoons"
    
    space()
    
    print ("What you entered: " + str(ingredient_number) + " " + ingredient_type + " of " + ingredient_name)

    rounded_number = round(operation(multiply_or_divide, number), 3)

    math = str(rounded_number) + ingredient_type + " of " + ingredient_name
    
    whole_recipe.append(math)
    
    space()

space()

print ("Converted recipe: " + str(whole_recipe))