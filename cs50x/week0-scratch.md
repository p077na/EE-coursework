Computer science = problem solving

input -> ... -> output

How to Count to 31 on One Hand by Using the Binary Counting System -> https://www.youtube.com/watch?v=Bke95oWWZII

binary system consists of 0's and 1's

Analogy: 0 - lightbulb off; 1 - lightbulb on

Each place in a binary number corresponds to a power of 2

2^2; 2^1; 2^0
1  ;   0;   1 
= 5 in decimal

This is physically stored in the form of electrical voltage levels using transistors.

There are two main ways a computer stores bits:

In RAM (Random Access Memory) — volatile storage (temporary)

In registers or caches — using flip-flops, which are made of transistors

 VOLTAGE LEVELS: THE ELECTRIC LANGUAGE OF COMPUTERS
Every wire in a digital circuit can be either:

High voltage (e.g., +5V or +3.3V or +1.8V) → represents binary 1

Low voltage (e.g., 0V) → represents binary 0

These voltage levels are interpreted by the circuit as logical 1 and 0.

But wires don't remember voltage. That’s where transistors come in.

🔹 TRANSISTORS: THE SWITCHES OF COMPUTING
A transistor is like a tiny electronic switch or valve. It can:

Open/close circuits to let current pass

Amplify signals

Store a state when arranged in specific ways (e.g. in a flip-flop)

A bit is not stored in a single transistor, but in a circuit made of multiple transistors that keep the voltage in a stable state.

🔹 FLIP-FLOP: THE BASIC MEMORY CELL
The most common type is the SR flip-flop or D flip-flop.

Let’s explain a D flip-flop, used in registers:

➤ What It Does:
Stores 1 bit of data

Has an input D, a clock signal CLK, and an output Q

When the clock ticks, the flip-flop saves whatever is at input D and holds it at output Q

Holds the value indefinitely until the next clock pulse

➤ What It's Made Of:
A D flip-flop is built from:

Logic gates (AND, NOT, NAND, etc.)

Each logic gate is made of 2–3 transistors

A full flip-flop uses around 4–6 transistors

It uses feedback loops — output of one gate feeds into another — to stabilize the voltage. This creates a latching behavior: the circuit stays in one state (0 or 1) until deliberately changed.
