from keras.models import Sequential
import matplotlib.pyplot as plt
# for normal deep learning models, fully connected layers
from keras.layers import Dense, Dropout, Activation, Flatten


#for extra utility
from keras.utils import np_utils

from time import time
import numpy as np
import pandas as pd


np.random.seed(123)  # for reproducibility
# 1. Import modules an libraries


#for data sets
from keras.datasets import mnist

# For Visualization
from keras.callbacks import TensorBoard


dataset = pd.read_csv("C:\\Users\\ROG\\PycharmProjects\\ROGPY\\Keras_K\\gradTest\\Book1.csv")

dataset.dtypes
cols = dataset.columns[0:29]

x = dataset[cols]


X_Train = x.iloc[:1000].values
#X_Train = X_Train.T
X_Test = x.iloc[1000:].values
#X_Test = X_Test.T


# Very IMPORTANT
# Deciding over the Threshhold of admit
# We are taking all results above above 80 %
# hence our results would be a bit pesimistic about selection
Y = pd.read_csv("Y_Train.csv")


Y_Train = Y.iloc[:1000].values
Y_Test = Y.iloc[1000:].values

print(X_Train)
# Step 4: Preprocess class labels
#Y_Train = np_utils.to_categorical(Y_Train)
#Y_Test = np_utils.to_categorical(Y_Test)


#ANN Design


# 5. Define model architecture
GradClass = Sequential()

#layer 1

GradClass.add(Dense(64, activation='relu', input_shape= (29,)))

GradClass.add(Dense(64, activation='relu'))

GradClass.add(Dense(10, activation='relu'))

# model.add(Dropout(0.5))
# not needed as the data set is already pretty small

# Add last layer of Softmax with #number of classification objects
# Y hat , SOFTMAX - final y vector
GradClass.add(Dense(8, activation='softmax'))

GradClass.compile(loss='categorical_crossentropy', optimizer='adam', metrics=['accuracy'])

epochs = 10

# Training the model over the designed NN
# All the data is from Train Set
GradClass.fit(X_Train, Y_Train,
          epochs=epochs,
          verbose=1)

# Finally testing the data over Test set that we separated out
score = GradClass.evaluate(X_Test, Y_Test, verbose=0)


# Making the predictions
print(GradClass.predict(X_Test))



history = GradClass.fit(X_Train, Y_Train, validation_split=0.25, epochs=10, verbose=1)

# Plot training & validation accuracy values
plt.plot(history.history['acc'])
plt.plot(history.history['val_acc'])
plt.title('Model accuracy')
plt.ylabel('Accuracy')
plt.xlabel('Epoch')
plt.legend(['Train', 'Test'], loc='upper left')
plt.show()
plt.savefig( f"{epochs}Accuracy.png")

# Plot training & validation loss values
plt.plot(history.history['loss'])
plt.plot(history.history['val_loss'])
plt.title('Model loss')
plt.ylabel('Loss')
plt.xlabel('Epoch')
plt.legend(['Train', 'Test'], loc='upper left')
plt.show()
plt.savefig('Loss.png')