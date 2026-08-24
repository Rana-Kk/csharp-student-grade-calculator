def get_score(exam_number):
    while True:
        try:
            score = float(input(f"Enter exam {exam_number} score (0-100): "))

            if 0 <= score <= 100:
                return score

            print("Score must be between 0 and 100.")

        except ValueError:
            print("Please enter a valid number.")


def calculate_average(scores):
    return sum(scores) / len(scores)


def main():
    name = input("Enter student name: ").strip()

    while not name:
        print("Name cannot be empty.")
        name = input("Enter student name: ").strip()

    scores = [
        get_score(1),
        get_score(2),
        get_score(3),
    ]

    average = calculate_average(scores)

    print("\n--- Result ---")
    print(f"Student: {name}")
    print(f"Average: {average:.2f}")

    if average >= 50:
        print("Status: Passed")
    else:
        print("Status: Failed")


if __name__ == "__main__":
    main()
