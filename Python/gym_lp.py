import pulp

# Define the problem
prob = pulp.LpProblem("Gym_Benefits_Simplified", pulp.LpMaximize)

# Define the variables
x1 = pulp.LpVariable('x1', lowBound=0, upBound=5, cat='Integer')  # Days at the gym (0-5 days)
x2 = 7 - x1  # Days not at the gym (complementary to x1)

# Define the objective function coefficients
b1 = 6  # Overall benefit coefficient (adjust as needed)
b2 = 2   # Penalty or cost coefficient (adjust as needed)
b3 = 2   # Benefit coefficient for muscular growth (adjust as needed)
b4 = 3   # Benefit coefficient for emotional impact (adjust as needed)

# Define functions for muscular growth (y1) and emotional impact (z1) as functions of x1
y1 = 0.5 * x1  # Example function: linear growth with days at the gym
z1 = 0.3 * x1  # Example function: linear emotional impact with days at the gym

# Define the objective function
prob += b1 * x1 + b3 * y1 + b4 * z1 - b2 * x2, "Total Benefits"

# Define the constraint: Maximum gym days (overtraining constraint)
prob += x1 <= 5, "Max Gym Days Constraint"

# Solve the problem
prob.solve()

# Print the results
print("Status:", pulp.LpStatus[prob.status])
print("Days at the gym:", x1.value())
print("Muscular Growth Impact:", y1)
print("Emotional Impact:", z1)
print("Days not at the gym:", x2.value())
print("Total Benefits:", pulp.value(prob.objective))
