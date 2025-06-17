# Computer Fundamentals

In the early days, computers were large machines built with vacuum tubes, which acted as electronic switches. These tubes were bulky, fragile, consumed a lot of power, and produced significant heat, which made the machines unreliable and inefficient. The big shift happened in 1947 when John Bardeen, Walter Brattain, and William Shockley invented the transistor.

### Transistor

Transistors performed the same switching function as vacuum tubes but were much smaller, more durable, generated less heat, consumed less power, and were significantly cheaper to produce. Moreover, they were made from silicon, a material derived from sand, which is abundant and inexpensive. This made transistors easy to mass-produce and integrate into circuits.

### Integrated circuit

An Integrated Circuit (IC) is a small, flat piece of semiconductor material—usually silicon—that contains a complete electronic circuit, made up of (thousands, millions) transistors, resistors, capacitors, and connecting wires, all built directly onto the chip in a fixed layout. All components are permanently embedded using a complex process called photolithography. 

The silicon chip itself is very fragile, so it's placed inside a protective case (called a package), which has metal pins or contacts, so you can connect it to other components.

Types of ICs: Logic ICs: perform digital logic (AND, OR, NOT, etc.); Memory ICs: store data (RAM, ROM); Microprocessors / Microcontrollers: complete processing units on a chip.

As technology advanced, more transistors could be packed into the same space. Here are the current levels of integration:

- SSI (Small Scale Integration): 10 to 100 transistors

- MSI (Medium Scale Integration): 101 to 500 transistors

- LSI (Large Scale Integration): 501 to 20,000 transistors

- VLSI (Very Large Scale Integration): 20,001 to 1 million transistors

- ULSI (Ultra Large Scale Integration): 1 million to 1 billion transistors

- GSI (Giga Scale Integration) more than 1 billion transistors

## Von Neumann architecture

Von Neumann architecture is the fundamental model of how most computers work today. Proposed in 1945, it describes a computer as made up of five main functional units, each responsible for a key task:

**Input Unit** is the interface through which data and instructions enter the computer. This includes devices like keyboards, mice, or sensors.

**Output Unit** sends results from the computer to the outside world, like through a screen, printer, or speaker.

**Memory Unit** stores data and instructions. It includes both the information being processed and the program controlling the processing. There's main memory (fast, used by CPU) and secondary memory (slower, larger, like a hard disk).

**Arithmetic Logic Unit (ALU)** performs all mathematical operations (like addition or subtraction) and logical decisions (like comparisons or Boolean operations).

**Control Unit (CU)** coordinates all the other units. It receives signals from other parts of the computer and sends control signals to make sure everything happens at the right time and in the correct order.

## CPU

**The CPU, or Central Processing Unit**, is the main part of a computer responsible for executing instructions. It reads one instruction from memory, processes it, and then moves to the next one. The CPU is often referred to as the "processor."

It is made up of three key elements:

1. The Arithmetic Logic Unit (ALU)

2. The Control Unit (UC), which manages and directs the operation of the processor by sending control signals to other components.

3. The internal registers, which are small, very fast storage locations used to temporarily hold data or instructions during processing.

### Microprocessor

A **microprocessor** is a single integrated circuit (IC) that contains all of those CPU parts (ALU, CU, registers, etc.) on one chip. It performs the same functions as a CPU but is more compact and widely used in modern devices. Before microprocessors, the CPU was built from multiple ICs or even discrete components spread across an entire board.

### Socket

The **socket** is a physical and electrical connector on the motherboard that allows the microprocessor to be securely attached and connected to the rest of the system. It ensures both mechanical support and electrical communication between the CPU and other parts of the computer.

### Multicore Technology

**A multicore or multinúcleo processor** is a single chip that contains two or more independent CPU cores. Each core can execute instructions separately, which allows the processor to run multiple tasks in parallel, increasing performance and efficiency without increasing the clock speed. This is especially useful for multitasking, heavy computations, and modern software that can use several threads.

### The speed of a microprocessor

The speed of a microprocessor is usually measured in two ways:

MIPS (Millions of Instructions Per Second): counts how many generic instructions it can process per second.

FLOPS (Floating Point Operations Per Second): focuses on complex numerical operations, common in scientific or 3D applications.

One of the most used performance metrics is **GFLOPS**, which combines the number of cores, clock frequency in GHz, and how many floating point operations each core can perform per clock cycle. The formula is:

$GFLOPS = cores \times GHz / core \times FLOP / cycle$

For example, if a processor has 2 cores, each running at 2.5 GHz, and can perform 4 FLOP per cycle, it achieves 20 GFLOPS.

### Chipset

A chipset is a group of specialized ICs on the motherboard that work alongside the CPU to manage communication between the CPU and other parts of the system — like RAM, storage, USB, graphics cards, and more. The chipset allows the CPU to delegate tasks and focus on executing programs efficiently.

## Main/Primary memory

Main memory (or primary) consists of ROM and RAM.

### RAM

RAM is a short-term essential memory for storing both the data and instructions that the processor uses during program execution **temporarily**. Once the power is turned off, everything stored in main memory is erased. 

It is needed because the CPU is extremely fast, but it can’t store much data itself. It needs a fast-access space to store the program it’s executing and the data it's currently working on

Main memory is organized in small storage units called cells, each capable of holding a single bit (0 or 1). Cells are grouped into words (usually 8, 16, 32, or 64 bits). A "word" is a standard unit of data that can be read from or written to memory in one operation. For example, a word might be 8 bits (1 byte) or more, depending on the system. Each word is assigned a unique address.

When the CPU wants to read or write something, it does the following:

1. Sends the address through the address bus
2. Sends a read (RD) or write (WR) control signal
3. Exchanges the data through the data bus
4. Waits for a READY signal from memory

### ROM

ROM (Read Only Memory) is non-volatile—its contents are preserved even when the power is turned off. ROM stores firmware: essential low-level software that tells the hardware what to do before the operating system starts.

It allows random access (you can access any memory location directly), but you cannot write or modify its contents during normal operation.

ROM is read-only, meaning the processor can only read from it, not write to it. This protects critical software from being accidentally changed or erased.

## Secondary memory

Secondary memory, which is used for long-term and large-scale data storage.

While main memory (RAM) is very fast, it is also expensive and typically limited in size. That's why computers also use secondary memory, which stores much larger amounts of information more cheaply, although with slower access times.

Secondary memory is non-volatile, meaning it retains data even when the power is off. It includes storage devices like:

- HDDs (Hard Disk Drives): magnetic disks, slower but cheap and with large capacities.

- SSDs (Solid State Drives): faster and more resistant because they have no moving parts, but they are more expensive per GB.

- USB flash drives: small, portable, and practical for transferring files.

- Flash memory cards: used in devices like cameras or smartphones.

## Cache

Cache memory is a special type of volatile memory built into the processor. What makes it unique is its very high speed. Its main purpose is to store instructions and data that the processor needs to access very frequently, so it doesn’t have to rely on slower main memory (RAM) for every operation.

**Hierarchy of Cache Memory: L1, L2, L3**

**L1 Cache (Level 1)**.
It is the closest cache to the processor core, and also the fastest. It operates at the same speed as the core. It is very small (typically tens of kilobytes). It is usually split into two parts: one for instructions and one for data. Because it’s so fast, the processor always checks L1 first when it needs data or an instruction.

**L2 Cache (Level 2)**.
Located next to the core, but not inside it. Slightly slower than L1 but much larger (hundreds of kilobytes or even megabytes). Still much faster than main RAM. Acts as a second checkpoint if the required data isn’t found in L1.

**L3 Cache (Level 3)**.
This cache is shared between all cores of a multicore processor. It is slower than L2 but has a much larger capacity (several megabytes). It sits between the cores and RAM. Its role is to store data that is accessed often but not enough to be in L1 or L2. Even though it is slower, it is still significantly faster than RAM.

### Input/Output (I/O) Devices

Input/output (I/O) devices are the hardware components that allow a computer to interact with the outside world — they either bring data into the computer (input) or send data out from the computer (output). Some devices do both.

Input devices: keyboards, mice, and scanners, microphone, camera

Output devices: monitors, printers, and speakers that give data from the computer. 

The system uses dedicated controllers and interfaces to manage this communication, ensuring that data moves efficiently between the CPU, memory, and peripherals.

**Methods for handling I/O operations**

1. **Programmed I/O**. In this method, the CPU constantly checks the I/O device to see if it’s ready. This is called polling — like asking over and over: "Are you ready? Are you ready? Are you ready?" This method is very inefficient, especially for large or slow devices (like printers or disks).

2. **Interrupt-Driven I/O**. Here, the I/O device interrupts the CPU only when it’s ready. Instead of the CPU checking constantly, the device just says:"Hey, I’m ready!". The CPU is free to do other work while it waits.

3. **DMA (Direct Memory Access).** DMA is the most efficient method for large data transfers. Instead of the CPU being involved in every step, the I/O device talks directly to RAM through the DMA controller. For example, when copying a video file to disk: The DMA controller transfers the data from memory to the disk without bothering the CPU. CPU is almost not involved

## Memory storage units

Everything starts with the bit (binary digit: 0 or 1). One byte equals 8 bits. Bytes are the basic unit for representing a character (like a letter or number) in memory.

From there, storage units grow in powers of 2—not powers of 10—because computers operate in binary (base 2):

- 1 KByte (kilobyte) = 2¹⁰ = 1,024 bytes

- 1 MByte (megabyte) = 2²⁰ = 1,048,576 bytes

- 1 GByte (gigabyte) = 2³⁰ = 1,073,741,824 bytes

- 1 TByte (terabyte) = 2⁴⁰ bytes

- 1 PByte (petabyte) = 2⁵⁰ bytes

- 1 EByte (exabyte) = 2⁶⁰ bytes

- 1 ZByte (zettabyte) = 2⁷⁰ bytes

- 1 YByte (yottabyte) = 2⁸⁰ bytes

## Bus

A bus in computing refers to the set of physical connections (like wires or printed circuit paths) that allow different hardware components—such as the CPU, memory, and I/O devices—to communicate with each other. Instead of having a direct wire for each connection, components share the same communication path, taking turns using it.

There are three main buses:

- Data bus: carries the actual data.

- Address bus: carries memory or device addresses.

- Control bus: carries control signals (e.g. read/write commands).

Transfer rate depends on:

- Bus width (called “ancho”): how many bits can be transferred at once (e.g. 16-bit, 32-bit).

- Bus frequency: how many transfers happen per second, measured in Hertz (Hz).

To calculate transfer rate, multiply the bus width by the frequency. For example, a 16-bit bus at 133 MHz can transmit: 16 bits x 133 million times per second = 2128 million bits per second. Dividing by 8 gives: 266 megabytes per second (MB/s)

### Driver

A driver is a small software program that lets the operating system communicate with hardware through the corresponding controller circuits. Without the driver, the OS can’t "talk" to the hardware, like USB devices or graphics cards.

### UEFI

UEFI (Unified Extensible Firmware Interface) is low-level software that starts when the computer is powered on. It:

- Check the hardware: Is the RAM okay? Is the CPU working? Are the disks connected?

- Initialize devices: It prepares everything so the operating system (macOS, Windows, Linux) can use them.

- Find and launch the OS: UEFI looks at your storage (e.g. SSD) and loads the bootloader that starts your operating system.

It also provides a configuration menu where users can adjust system-level settings before the OS starts.

### Motherboard

The motherboard (also called mainboard or placa base) is the central circuit board of the computer. It's where all major components connect and communicate with each other. Physically, it's a synthetic board with copper circuits where key parts are placed:

- The microprocessor sits in a socket and performs calculations.

- Memory modules, like RAM, are inserted into dedicated memory slots.

- Expansion slots allow you to add cards such as graphics or sound cards.

Various control chips handle specific functions like USB or network connections.

### Slotsor expansion sockets

A slot is a connector on the motherboard where you plug in an adapter card. These adapter cards expand the computer’s capabilities by adding new features. For example, a graphics card can go into a PCI Express slot to allow for advanced video rendering. These slots are standardized, so different types of cards can be easily added.

### Physical port

A puerto físico (physical port) is a hardware connector on the computer that allows it to communicate with external devices like keyboards, mice, cameras, USB sticks, speakers, etc.

Each type of port has a specific shape and function. For example:

USB ports (Universal Serial Bus) are the most common and used for connecting almost everything—mice, keyboards, flash drives, printers.

Audio ports allow connection of microphones, headphones, and speakers.

HDMI and DVI ports are used to connect monitors or TVs for video output.

Network port (Ethernet) connects the computer to a wired internet or local network.

FireWire ports (now obsolete) were used for high-speed data transfer with cameras or external drives.

Serial and PS/2 ports (mouse and keyboard) are older connectors used before USB became standard.

Memory card readers allow direct reading of SD cards and similar formats, used in cameras.

# Operating Systems and Databases

## Programming Languages

In computer systems, programming languages are classified into different levels based on how close they are to the machine's hardware or to human understanding. From lowest to highest level:

### Machine Language 

This is the lowest level possible — the raw binary code (0s and 1s) that a computer’s CPU can directly understand and execute.

- It’s specific to a processor’s architecture.

- Extremely fast, but unreadable for humans.

- No abstraction: every instruction must be written manually.

Example: 10110100 00000011 (this might represent moving the number 3 into a CPU register).

### Assembly Language (Lenguaje ensamblador / simbólico bajo nivel)

Assembly is slightly above machine language. It uses mnemonics (symbolic names) to represent instructions.

- Still hardware-specific (tied to the CPU architecture)

- Much easier to read than binary but still complex

- Needs an assembler to convert it into machine code

Example: MOV AX, 3 (move value 3 into register AX).

### High-Level Languages (Lenguajes de alto nivel)

These are languages designed to be easy for humans to read and write. They abstract away hardware details and allow programmers to write instructions closer to natural language or math.

- Portable across hardware (not CPU-specific)

- Requires a compiler or interpreter to run

- Includes features like variables, functions, loops, etc

Examples:

- C, C++ (still quite close to hardware, often called "mid-level")

- Java, C#, Python (more abstract and user-friendly)

## Translator

A computer can only understand and execute programs written in binary (machine language). Any program written in a higher-level language (like C, Java, Python) must be translated into binary before the computer can run it.

Lenguaje máquina (Machine Language): The only language your computer's processor understands directly. It's a sequence of 0s and 1s (binary).

Lenguaje fuente (Source Language / Source Code): This is the code a human writes, using a programming language like Python or Java. It’s not understandable by the machine directly.

Lenguaje objeto (Object Language / Object Code): This is the translated version — in binary — that the machine can execute. Machine language instructions produced by a translator (compiler/assembler).

Traductor (Translator): A program that translates source code into machine code.
There are different types of translators, like:

- Compilers (e.g., for C or Java)

- Interpreters (e.g., for Python)

- Assemblers (for assembly language)

The translator turns human-readable code into machine-readable code.

### Translation Process

When you write a program in a high-level language like C, or even in assembly language — you are writing the source program.

This source program readable by humans, but meaningless to the CPU. 

To make that program executable by the computer, we need to translate it.
The translator — usually a compiler or assembler — takes your source program and converts it into a machine language version. We call the result the object code.

And this object code is in machine language — it's the actual instructions the processor understands and can execute.

During this translation process, two kinds of problems can arise.

1. **Compilation Errors (Errors in translation).** If you forgot a semicolon or called a variable that doesn’t exist. The compiler can’t complete the translation. It throws an error.

    Compilation errors (or syntax errors) happen before the program ever becomes object code. Your program won’t run until you fix them.

    You go back, open your source code, fix the issue, and try again.

2. **Execution or Runtime Errors (Errors during program run)**
Your program compiles successfully and is now translated into machine code, and the computer starts executing it.

    But during execution, something goes wrong: dividing by zero, accessing an element outside the bounds of an array.

    They don’t stop the compiler, because the compiler doesn’t know how the program will behave while it's running. But the machine encounters something invalid and throws an error while executing the already-translated program.


### Compilers and Assemblers

The journey from high-level code to machine code typically involves a compiler and an assembler

In some environments, these steps may be merged or skipped (e.g., interpreted languages).

1. High-Level Language → Compiler → Assembly

If you write this in C#:

    static void swap(int[] v, int k) {
        int temp = v[k];
        v[k] = v[k + 1];
        v[k + 1] = temp;
    }

A compiler translates this high-level source code into a low-level representation, typically:

Assembly language (human-readable version of machine code), or directly into machine code (binary), depending on the system and settings.

So in most traditional systems:

High-level code (C/C#/Java) → Compiler → Assembly

1. Assembly → Assembler → Machine Code

Once the compiler has generated assembly, it’s time for the assembler to do its job. An assembler is a program that translates assembly language into machine language (raw binary instructions).

Now this is pure binary — machine code that the CPU will execute directly.

Each CPU has its own Instruction Set Architecture (ISA) — a set of binary instructions it knows how to decode. The assembler’s job is to map each assembly instruction to its correct binary equivalent in that architecture.

*High-Level Language (C#, C, etc.) → Compiler → Assembly Code (for the target CPU) → Assembler → Machine Code (binary, 0s and 1s) → CPU Executes*

## Operating Systems

The hardware, the physical components like the processor, memory chips, hard drives, screen, keyboard, etc. by itself is silent.
An Operating System (OS) is a complex, layered set of programs whose primary mission is to make hardware usable for humans and software applications.

It has two main goals:

- Abstraction — to hide the complexity of hardware behind a simpler, logical interface (e.g., you don’t have to manually move bytes into RAM — the OS handles that).

- Resource management — to control and allocate resources like CPU time, memory space, disk storage, and device input/output among different users and programs safely and efficiently.

### Functions 

1. **Controls Hardware Access.**
   
    If you open two programs at once — a browser and a music player. Both want to use: CPU, RAM, the sound card and the file system.

    But the hardware can’t manage that complexity on its own. The OS:

   -  Decides which program gets the CPU and for how long

   -  Assigns each program its own memory space

   -  Prevents them from corrupting each other’s data

   -  Translates software instructions into hardware-level commands

2. **Provides a Software Interface (APIs).**
   
    Applications don’t talk directly to hardware. Reasons:

   - Security – You don’t want a random app accessing raw memory or turning off your disk.

   - Complexity – Every hardware device is different; programmers shouldn’t need to understand low-level hardware signals.

   - Consistency – You want programs to run the same way across different computers.

   Instead, they use system calls — like asking the OS:

    “Can you read this file for me?”; “Can you allocate memory for this variable?”; “Can you draw a window on the screen?”

   The OS exposes an **Application Programming Interface (API)** — a software layer that apps use to request services from the OS. The OS checks that the request is allowed and then interacts with the hardware safely, returning the result to the application.

3. **Boots and Initializes the System**
   
   When you power on your computer: A tiny program (BIOS or firmware) hands control over to the operating system. The OS then initializes all components: loads drivers, mounts filesystems, prepares user environments.

4. **File and Storage Management**
   
    The OS organizes all the data on your disk into a file system: files, folders, permissions, access times.

    Every time you save a file or load one, you're not accessing the hardware directly — you're asking the OS to manage those disk operations for you in a safe, efficient way.

5. **Security and User Access Control**

If multiple users share the same machine — or even if one user has multiple apps open — the OS enforces permissions, authentication, and isolation between them.

Any device with a microprocessor and any kind of functionality has an OS.

- General-purpose OSes: Windows, Linux, macOS

- Mobile OSes: Android, iOS

- Embedded OSes: RTOS for robots, firmware for routers, OS in ATMs, cars, smart TVs

## Databases

A database is a structured collection of data.

The data is organized, related to a specific domain (context), retrievable, updatable, and manageable.

Relational Database is used type of database — used in banking systems, websites, schools, government institutions, everything.

A relational database organizes all its data in tables.

A Table Has:
Columns (also called fields or attributes): define the structure

For example: Department Name, Director, Budget

Rows (also called records or tuples): actual data entries

Example row: Accounting | Burrell | 350,000

**Every row represents one real-world entity.**

**Every column represents one characteristic of that entity.**


### DBMS (Database Management System)

The database isn’t just data. There’s a program — software — that controls it. That’s the DBMS:

- stores and organizes data in tables on disk
- accepts queries from the user (e.g., “Show all departments with a budget > 500,000”)
- processes those queries efficiently
- returns the results in a structured way
- manages access (permissions, users)
- prevents errors, corruption, duplicates
- handles multiple users at once

You never interact with the data directly. You talk to the DBMS, and the DBMS talks to the data.

- MySQL – widely used in web development
- PostgreSQL – powerful, open-source
- Oracle DB – used in large corporations
- SQLite – embedded in apps and mobile devices

They all follow the same logic: tables, rows, columns, structured access — but differ in scale and features.

### How databases work 

1. Each Table Has a Unique Name
   
    You cannot have two tables called Users in the same database. Every table needs to have a unique identifier so that when you query the database, the system knows exactly which set of data you're referring to.

2. Atomic Column Values

    Each cell in the table must contain a single value, not a list, not a complex object.

    This rule — called atomicity — makes querying, indexing, and updating predictable and fast. If you want to store multiple values (like multiple directors), you should split that into a separate table, and model the one-to-many relationship properly.

3. No Duplicate Column Names

    Every column in a table must have a unique name.

4. Column and row Order Doesn’t Matter

    The order of columns (left-to-right) is not meaningful in the structure of the table.

5. No Duplicate Rows

    In theory, no two rows in a table should be completely identical. In practice, this rule is enforced using a primary key, which guarantees uniqueness.

### Primary Key 

A primary key is a column (or a combination of columns) that uniquely identifies each row in a table.

No two rows can have the same value for the primary key. And no primary key value can be NULL.

### Foreign Key

A foreign key is a column in one table that refers to the primary key of another table.

It’s how we link related data across different tables.

# Tema 3

A computer system is an information processing machine that receives inputs (data and instructions), performs operations on them according to a defined sequence of steps (the program), and produces outputs (results).

In computer science, the term data refers to any symbolic representation that can be stored, processed, or transmitted by a computer system. There are two complementary definitions:

Semantic definition: Data is a symbol used to represent a numerical value, fact, object, or idea that is amenable to processing by a computational system.

Operational definition: Data is a set of memory positions (or cells), each associated with an identifier (name) and a content (value). These values are stored in main memory or secondary storage, and not all data types occupy the same number of memory cells.

Computers operate using physical components capable of representing two distinct states. These states can be realized through different physical means:

- Magnetic polarity: Used in magnetic tapes and hard disk drives. Two directions of polarity represent two logical states.

- Electric voltage levels: Found in electronic circuits and conventional telecommunication lines. High vs. low voltage differentiates logical states.

- Presence or absence of light: Utilized in optical media such as CD-ROMs and fiber-optic communication. Light on/off encodes binary values.

These two physical states are abstracted as the binary digits: 0 (zero) ; 1 (one)

This abstraction enables digital information processing. Each of these binary digits is called a bit (short for binary digit), and it constitutes the minimum unit of storage in any digital system.

All complex data structures (numbers, characters, images, programs) are constructed from sequences of bits, interpreted according to context-specific encoding schemes.

Due to the extremely limited expressive capacity of a single bit, bits are grouped into fixed-size blocks. The most basic and universally adopted grouping is the byte. A byte can represent 2^8 = 256 distinct values. This arises from the number of possible binary combinations of 8 positions, each of which may independently hold the value 0 or 1.

### Memory Capacity 

The memory capacity of a computing system is quantified by the total number of bytes it can store. Given the relatively small magnitude of a byte, memory and storage units are commonly expressed in multiples of bytes, following binary powers of 2.

| Name      | Symbol | Power of 2 | Exact Value (Bytes)               | Approx. Decimal Equivalent |
| --------- | ------ | ---------- | --------------------------------- | -------------------------- |
| Kilobyte  | KB     | $2^{10}$   | 1,024                             | $10^3$                     |
| Megabyte  | MB     | $2^{20}$   | 1,048,576                         | $10^6$                     |
| Gigabyte  | GB     | $2^{30}$   | 1,073,741,824                     | $10^9$                     |
| Terabyte  | TB     | $2^{40}$   | 1,099,511,627,776                 | $10^{12}$                  |
| Petabyte  | PB     | $2^{50}$   | 1,125,899,906,842,624             | $10^{15}$                  |
| Exabyte   | EB     | $2^{60}$   | 1,152,921,504,606,846,976         | $10^{18}$                  |
| Zettabyte | ZB     | $2^{70}$   | 1,180,591,620,717,411,303,424     | $10^{21}$                  |
| Yottabyte | YB     | $2^{80}$   | 1,208,925,819,614,629,174,706,176 | $10^{24}$                  |

These units are used to describe the size of:

- RAM (Random Access Memory)

- Hard drives and solid-state storage

- Files and data structures in persistent storage

### Positional Number Systems in Computing

| System      | Base $b$ | Alphabet                   |
| ----------- | -------- | -------------------------- |
| Binary      | 2        | 0, 1                       |
| Octal       | 8        | 0–7                        |
| Decimal     | 10       | 0–9                        |
| Hexadecimal | 16       | 0–9, A–F (A=10, ..., F=15) |


## Binary–Decimal Conversion with Fractions

### Fractional Binary → Decimal

A binary number with a fractional part (e.g. $101.101_2$) is converted to decimal using positional weights.

Each digit. Multiply:
- the integer part by powers of 2 
- the fractional part by negative powers of 2

### Fractional Decimal → Binary

To convert a decimal fraction to binary, use multiplication by 2.

### Algorithm:

1. Multiply the fractional part by 2.
2. Record the **integer part** (0 or 1) — this becomes the next binary digit.
3. Take the new **fractional part** and repeat.
4. Stop when the fractional part is 0 or desired precision is reached.

## Arithmetic Operations in Binary

### Addition

| a | b | Sum (s) | Carry (c) |
| - | - | ------- | --------- |
| 0 | 0 | 0       | 0         |
| 0 | 1 | 1       | 0         |
| 1 | 0 | 1       | 0         |
| 1 | 1 | 0       | 1         |


### Substraction

| a | b | Difference (d) | Borrow |
| - | - | -------------- | ------ |
| 0 | 0 | 0              | 0      |
| 0 | 1 | 1              | 1      |
| 1 | 0 | 1              | 0      |
| 1 | 1 | 0              | 0      |

### Multiplication

| a | b | Product (p) |
| - | - | ----------- |
| 0 | 0 | 0           |
| 0 | 1 | 0           |
| 1 | 0 | 0           |
| 1 | 1 | 1           |

### Division

| a (numerator) | b (denominator) | Quotient (q) |
| ------------- | --------------- | ------------ |
| 0             | 0               | Undefined    |
| 0             | 1               | 0            |
| 1             | 0               | ∞ (invalid)  |
| 1             | 1               | 1            |


## Signed and Unsigned

An unsigned binary number can only represent non-negative values (zero and positive integers).

A signed binary number can represent both positive and negative values.

### Two's Complement

The most common format is two’s complement, where:

The most significant bit (MSB) indicates the sign (0 = positive, 1 = negative),

The remaining bits encode the magnitude.

