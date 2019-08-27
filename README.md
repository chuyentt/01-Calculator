# 01-Calculator
Calculator - Các phép toán với hai số nguyên

## Mục tiêu
- [x] Hiểu cách thực thi ứng dụng với tham số args
- [x] Biết cách chuyển chuỗi thành số có kiểm soát lỗi
- [x] Ôn lại điều kiện rẽ nhánh và điều kiện lặp
- [x] Biết trình bày kết quả ra màn hình
- [x] Biết tách một chuỗi thành các chuỗi con
- [x] Biết sử dụng biến thường và biển mảng

## Phát biểu bài toán
Là một người dùng, tôi muốn thực thi ứng dụng cùng với hai giá trị cho trước để hiểu các phép toán cơ bản là cộng (+), trừ (-), nhân (*) và chia (/). Ví dụ:
```bash
C:\>Calculator 8 2
```
Trong trường hợp không có tham số thì tôi có thể nhập vào từ bàn phím. Ví dụ:
```bash
Các phép toán với hai số nguyên
-------------------------------
Nhập vào hai số nguyên: 8 2
```

## Thuật toán

- Tạo các biến và khởi tạo giá trị ban đầu
- Kiểm tra tham số khi thực thi chương trình
- Nếu có tham số và số tham số lớn hơn hoặc bằng 2
  - Nếu chuyển sang số thành công thì in ra màn hình các phép toán cộng, trừ, nhân
    - Nếu số thứ hai khác không thì in ra màn hình phép toán chia, 
    - nếu không thì in ra màn hình chữ Chia cho 0.
  - Nếu chuyển sang số không thành công thì yêu cầu nhập vào 2 số từ bàn phím
- Nếu không có tham số thì yêu cầu nhập vào 2 số từ bàn phím
  - Nếu chuyển sang số thành công thì in ra màn hình các phép toán cộng, trừ, nhân
    - Nếu số thứ hai khác không thì in ra màn hình phép toán chia, 
    - nếu không thì in ra màn hình chữ Chia cho 0.
  - Nếu chuyển sang số không thành công thì yêu cầu nhập vào 2 số từ bàn phím
  ...

## Lưu đồ thuật toán
<img src="./Calculator/Docs/01-Flowchart.svg">

## Các biến
- args - các tham số đầu vào
- num1, num2 - biến chứa hai số nguyên
- success - biến kiểm tra
