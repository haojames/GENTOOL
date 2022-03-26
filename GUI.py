from PyQt5.QtWidgets import (QApplication, QCheckBox, QGridLayout, QGroupBox,
        QMenu, QPushButton, QRadioButton, QVBoxLayout, QWidget, QLabel, QLineEdit)
import PyQt5.QtGui as GUI
from PyQt5.QtCore import pyqtSlot
import sys

from PyQt5 import QtCore, QtGui, QtWidgets


class MainWindows(QtWidgets.QWidget):
	def __init__(self):
		super().__init__()
		self.setWindowTitle("GEN TOOL 2.0") #Title
		grid = QGridLayout()
		grid.addWidget(self.createGroupbox1(), 0, 0)
		grid.addWidget(self.createGroupbox2(), 1, 0)
		self.setLayout(grid)
		button = QPushButton('RUN', self)
		button.move(15,400)
		button.clicked.connect(self.on_click)
		self.show()
	"""
	Create groupbox 1 to choice option need complie
	"""
	def createGroupbox1(self):
		groupbox = QtWidgets.QGroupBox("OPTION")
		radio1 = QRadioButton("Excel -> XML")
		radio2 = QRadioButton("XML -> Excel")


		radio1.setChecked(False)
		radio2.setChecked(False)


		vbox = QVBoxLayout()
		vbox.addWidget(radio1)
		vbox.addWidget(radio2)
		#vbox.addStretch(1)
		groupbox.setLayout(vbox)
		return groupbox



	@pyqtSlot()
	def on_click(self):
		print('Success Click')
	"""
	createGroupbox2 use input and output data. 
	"""
	def createGroupbox2(self):
		groupbox2 = QtWidgets.QGroupBox("INPUT AND OUTPUT PATH")
		label_1 = QLabel(self)
		label_1.setText('INPUT PATH')
		line_edit_1 = QLineEdit(self)

		label_2 = QLabel(self)
		label_2.setText('OUPUT PATH')
		line_edit_2 = QLineEdit(self)

		line_edit_1.move(80, 20)
		line_edit_1.resize(200, 32)
		label_1.move(20, 20)

		line_edit_2.move(80, 20)
		line_edit_2.resize(200, 32)
		label_2.move(20, 20)

		vbox2 = QVBoxLayout()
		vbox2.addWidget(label_1)
		vbox2.addWidget(line_edit_1)
		vbox2.addWidget(label_2)
		vbox2.addWidget(line_edit_2)
		vbox2.addStretch(2)
		groupbox2.setLayout(vbox2)
		return groupbox2


# Run Application
if __name__ == '__main__':
	app = QtWidgets.QApplication([])
	window = MainWindows()
	#flags = Qt.WindowFlags()
	#window.setWindowFlags(flags)
	app.exec_()